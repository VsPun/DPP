﻿using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.ArcMapUI;
using ESRI.ArcGIS.Carto;
using MilSpace.Core;
using MilSpace.Core.Actions;
using MilSpace.Core.Actions.ActionResults;
using MilSpace.Core.Actions.Base;
using MilSpace.Core.Actions.Interfaces;
using MilSpace.Core.Tools.SurfaceProfile.Actions;
using MilSpace.Configurations;
using System.Reflection;
using System.IO;
using System.Linq;
using System.Windows.Media;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geometry;
using MilSpace.DataAccess.Facade;
using Point = ESRI.ArcGIS.Geometry.Point;

namespace MilSpace.Profile
{
    /// <summary>
    /// Designer class of the dockable window add-in. It contains user interfaces that
    /// make up the dockable window.
    /// </summary>
    public partial class DockableWindowMilSpaceProfileCalc : UserControl
    {
        public DockableWindowMilSpaceProfileCalc()
        {
            this.Instance = this;
        }        

        public DockableWindowMilSpaceProfileCalc(object hook)
        {
            InitializeComponent();

            this.Hook = hook;
            SubscribeForEvents();
            this.Instance = this;
        }

        public  DockableWindowMilSpaceProfileCalc Instance { get; }

        /// <summary>
        /// Host object of the dockable window
        /// </summary>
        private object Hook
        {
            get;
            set;
        }

        protected override void OnLoad(EventArgs e)
        {
            Helper.SetConfiguration();
        }

        private void OnRasterComboDropped()
        {
            
            cmbRasterLayers.Items.Clear();
            PopulateComboBox(cmbRasterLayers, ProfileLayers.RasterLayers);
        }


        private void OnRoadComboDropped()
        {

            cmbRoadLayers.Items.Clear();
            PopulateComboBox(cmbRoadLayers, ProfileLayers.LineLayers);
        }

        private void OnHydrographyDropped()
        {
            cmbHydrographyLayer.Items.Clear();
            PopulateComboBox(cmbHydrographyLayer, ProfileLayers.LineLayers);
        }

        private void OnVegetationDropped()
        {
            cmbPolygonLayer.Items.Clear();
            PopulateComboBox(cmbPolygonLayer, ProfileLayers.PolygonLayers);
        }

        private void OnObservationPointDropped()
        {
            cmbPointLayers.Items.Clear();
            PopulateComboBox(cmbPointLayers, ProfileLayers.PointLayers);
        }


        private static void PopulateComboBox(ComboBox comboBox, IEnumerable<ILayer> layers)
        {
            comboBox.Items.AddRange(layers.Select(l => l.Name).ToArray());
        }

        private void SubscribeForEvents()
        {

            //((IActiveViewEvents_Event) (ArcMap.Document.FocusMap)).ItemAdded += OnRasterComboDropped;
            ArcMap.Events.OpenDocument += OnRasterComboDropped;
            ArcMap.Events.OpenDocument += OnHydrographyDropped;
            ArcMap.Events.OpenDocument += OnObservationPointDropped;
            ArcMap.Events.OpenDocument += OnRoadComboDropped;
            ArcMap.Events.OpenDocument += OnVegetationDropped;

        }

        /// <summary>
        /// Implementation class of the dockable window add-in. It is responsible for 
        /// creating and disposing the user interface class of the dockable window.
        /// </summary>
        public class AddinImpl : ESRI.ArcGIS.Desktop.AddIns.DockableWindow
        {
            private DockableWindowMilSpaceProfileCalc m_windowUI;

            public AddinImpl()
            {
            }

            protected override IntPtr OnCreateChild()
            {
                m_windowUI = new DockableWindowMilSpaceProfileCalc(this.Hook);
                return m_windowUI.Handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (m_windowUI != null)
                    m_windowUI.Dispose(disposing);

                base.Dispose(disposing);
            }

            internal DockableWindowMilSpaceProfileCalc DockableWindowUI => m_windowUI;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArcMap.Application.CurrentTool = null;
            UID dockWinID = new UIDClass();
            dockWinID.Value = ThisAddIn.IDs.DockableWindowMilSpaceProfileGraph;
            IDockableWindow dockWindow = ArcMap.DockableWindowManager.GetDockableWindow(dockWinID);
            dockWindow.Show(true);
        }

        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            switch (firstPointToolBar.Buttons.IndexOf(e.Button))
            {
                case 0:
                        var commandItem = ArcMap.Application.Document.CommandBars.Find(ThisAddIn.IDs.PickCoordinates);
                        if (commandItem == null)
                        {
                            var message = $"Please add Pick Coordinates tool to any toolbar first.";
                            MessageBox.Show(message, "Profile Calc", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;

                        }
                        ArcMap.Application.CurrentTool = commandItem;

                    // Insert code to open the file.
                    break;
                case 1:
                   ;
                    // Insert code to save the file.
                    break;
                case 2:
                    
                    // Insert code to print the file.    
                    break;
            }
        }

        public void InitializeMyToolBar()
        {
            this.firstPointToolBar
                .ButtonClick += new ToolBarButtonClickEventHandler(
                this.toolBar1_ButtonClick);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //GdbAccess.Instance.EraseProfileLines();

            //Add lines
            var map = ArcMap.Document.ActiveView.FocusMap;
            var segment = GetSegment();
            var geometry = (IGeometry)segment;
            IRgbColor col = new RgbColorClass();
            col.Red = 133;
            col.Green = 135;
            col.Blue = 43;

            IRgbColor col2 = new RgbColorClass();
            col.Red = 133;
            col.Green = 135;
            col.Blue = 43;

            AddGraphicToMap(map, geometry,col, col2);


            GdbAccess.Instance.AddPrifileLinesToCalculation(segment.FromPoint.X, segment.FromPoint.Y, segment.ToPoint.X, segment.ToPoint.Y);


            var action = new ActionParam<string>()
            {
                ParamName = ActionParamNamesCore.Action,
                Value = ActionsEnum.bsp.ToString()
            };


            var profileSource = cmbRasterLayers.Text;
            string sdtnow = DateTime.Now.ToString("yyyyMMddHHmmss");
            var resuTable = $"{MilSpaceConfiguration.ConnectionProperty.TemporaryGDBConnection}\\StackProfile{sdtnow}";
            var profileLineFeatureClass = GdbAccess.Instance.ProfileLinesFeatureClass;



            var prm = new List<IActionParam>
            {
                action,
//                new ActionParam<string>() { ParamName = ActionParameters.FeatureClass, Value = "E:\\Data\\MilSpace3D\\3DUTM368.gdb\\FCProfiles\\Profile01_L"},
//                new ActionParam<string>() { ParamName = ActionParameters.ProfileSource, Value = "E:\\Data\\MilSpace3D\\3D\\cmr004" },
                new ActionParam<string>() { ParamName = ActionParameters.FeatureClass, Value = profileLineFeatureClass },
                new ActionParam<string>() { ParamName = ActionParameters.ProfileSource, Value = profileSource },
                new ActionParam<string>() { ParamName = ActionParameters.DataWorkSpace, Value = resuTable},
                new ActionParam<string>() { ParamName = ActionParameters.OutGraphName, Value = ""}
            };


            var procc = new ActionProcessor(prm);
            var res = procc.Process<StringActionResult>();

            MessageBox.Show("Calculated");
        }

        private ILine GetSegment()
        {
            //var firstPoint = new ESRI.ArcGIS.Geometry.Point();
            //var secondPoint = new ESRI.ArcGIS.Geometry.Point();
            //firstPoint.PutCoords(Double.Parse(txtFirstPointX.Text), Double.Parse(txtFirstPointY.Text));
            //secondPoint.PutCoords(Double.Parse(txtSecondPointX.Text), Double.Parse(txtSecondPointY.Text) );

            //var line = new Line();
            //line.FromPoint = firstPoint;
            //line.ToPoint = secondPoint;
            //line.Geom

            Point fromPoint = new PointClass();
            fromPoint.X = double.Parse(txtFirstPointX.Text, System.Globalization.CultureInfo.InvariantCulture);
            fromPoint.Y = double.Parse(txtFirstPointY.Text, System.Globalization.CultureInfo.InvariantCulture);

            Point toPoint = new PointClass();
            toPoint.X = double.Parse(txtSecondPointX.Text, System.Globalization.CultureInfo.InvariantCulture);
            toPoint.Y = double.Parse(txtSecondPointY.Text, System.Globalization.CultureInfo.InvariantCulture);

            ILine segment = new LineClass();
            segment.FromPoint = fromPoint;
            segment.ToPoint = toPoint;
            return segment;

        }

        public void AddGraphicToMap(ESRI.ArcGIS.Carto.IMap map, ESRI.ArcGIS.Geometry.IGeometry geometry,
            ESRI.ArcGIS.Display.IRgbColor rgbColor, ESRI.ArcGIS.Display.IRgbColor outlineRgbColor)
        {
            ESRI.ArcGIS.Carto.IGraphicsContainer graphicsContainer = (ESRI.ArcGIS.Carto.IGraphicsContainer)map; // Explicit Cast
            ESRI.ArcGIS.Carto.IElement element = null;
            if ((geometry.GeometryType) == ESRI.ArcGIS.Geometry.esriGeometryType.esriGeometryPoint)
            {
                // Marker symbols
                ESRI.ArcGIS.Display.ISimpleMarkerSymbol simpleMarkerSymbol = new ESRI.ArcGIS.Display.SimpleMarkerSymbolClass();
                simpleMarkerSymbol.Color = rgbColor;
                simpleMarkerSymbol.Outline = true;
                simpleMarkerSymbol.OutlineColor = outlineRgbColor;
                simpleMarkerSymbol.Size = 15;
                simpleMarkerSymbol.Style = ESRI.ArcGIS.Display.esriSimpleMarkerStyle.esriSMSCircle;

                ESRI.ArcGIS.Carto.IMarkerElement markerElement = new ESRI.ArcGIS.Carto.MarkerElementClass();
                markerElement.Symbol = simpleMarkerSymbol;
                element = (ESRI.ArcGIS.Carto.IElement)markerElement; // Explicit Cast
            }
            else if ((geometry.GeometryType) == ESRI.ArcGIS.Geometry.esriGeometryType.esriGeometryPolyline)
            {
                //  Line elements
                ESRI.ArcGIS.Display.ISimpleLineSymbol simpleLineSymbol = new ESRI.ArcGIS.Display.SimpleLineSymbolClass();
                simpleLineSymbol.Color = rgbColor;
                simpleLineSymbol.Style = ESRI.ArcGIS.Display.esriSimpleLineStyle.esriSLSSolid;
                simpleLineSymbol.Width = 5;

                ESRI.ArcGIS.Carto.ILineElement lineElement = new ESRI.ArcGIS.Carto.LineElementClass();
                lineElement.Symbol = simpleLineSymbol;
                element = (ESRI.ArcGIS.Carto.IElement)lineElement; // Explicit Cast
            }
            else if ((geometry.GeometryType) == ESRI.ArcGIS.Geometry.esriGeometryType.esriGeometryPolygon)
            {
                // Polygon elements
                ESRI.ArcGIS.Display.ISimpleFillSymbol simpleFillSymbol = new ESRI.ArcGIS.Display.SimpleFillSymbolClass();
                simpleFillSymbol.Color = rgbColor;
                simpleFillSymbol.Style = ESRI.ArcGIS.Display.esriSimpleFillStyle.esriSFSForwardDiagonal;
                ESRI.ArcGIS.Carto.IFillShapeElement fillShapeElement = new ESRI.ArcGIS.Carto.PolygonElementClass();
                fillShapeElement.Symbol = simpleFillSymbol;
                element = (ESRI.ArcGIS.Carto.IElement)fillShapeElement; // Explicit Cast
            }
            if (!(element == null))
            {
                element.Geometry = geometry;
                graphicsContainer.AddElement(element, 0);
            }
        }

        private async void AddPolylineToMap()
        {
            Map map = (Map) ArcMap.Document.ActiveView.FocusMap;
            var graphicLayerUUID = new ESRI.ArcGIS.esriSystem.UIDClass();
            graphicLayerUUID.Value = "MyGraphics";


            var graphicsLayer = ArcMap.Document.ActiveView.FocusMap.Layers[graphicLayerUUID] as Esri.ArcGISRuntime.Layers.GraphicsLayer;
            if (graphicsLayer == null)
            {
                graphicsLayer = new Esri.ArcGISRuntime.Layers.GraphicsLayer();
                graphicsLayer.ID = "MyGraphics";
              //  map.Layers.Add(graphicsLayer);
            }
            var lineSymbol = new Esri.ArcGISRuntime.Symbology.SimpleLineSymbol();
            lineSymbol.Color = Colors.Blue;
            lineSymbol.Style = Esri.ArcGISRuntime.Symbology.SimpleLineStyle.Dash;
            lineSymbol.Width = 2;

            // use the MapView's Editor to get polyline geometry from the user
          //  var line = await map.Editor.RequestShapeAsync(Esri.ArcGISRuntime.Controls.DrawShape.Polyline,
            //    lineSymbol, null);

            // create a new graphic; set the Geometry and Symbol
            var lineGraphic = new Esri.ArcGISRuntime.Layers.Graphic();
          //  lineGraphic.Geometry = line;
            lineGraphic.Symbol = lineSymbol;

            // add the graphic to the graphics layer
            graphicsLayer.Graphics.Add(lineGraphic);
        }

        private void ultraToolbarsManager1_ToolClick(object sender, Infragistics.Win.UltraWinToolbars.ToolClickEventArgs e)
        {

        }
    }
}
