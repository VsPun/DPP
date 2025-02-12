﻿using ESRI.ArcGIS.Analyst3DTools;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geoprocessing;
using ESRI.ArcGIS.Geoprocessor;
using MilSpace.Configurations;
using MilSpace.Core;
using System;
using System.Collections.Generic;

namespace MilSpace.Tools.SurfaceProfile
{
    public static class ProfileLibrary
    {
        private static readonly string environmentName = "workspace";
        private static readonly string temporaryWorkspace = MilSpaceConfiguration.ConnectionProperty.TemporaryGDBConnection;
        private static Logger log = Logger.GetLoggerEx("ProfileLibrary");
        private const string NonvisibleCellValue = "ZERO";

        //-------------------------------------------------------------------------
        static ProfileLibrary()
        {
        }

        //-------------------------------------------------------------------------
        internal static bool GenerateProfileData(
            string lineFeatureClass,
            string profileSource,
            string outTable,
            IEnumerable<string> messages,
            string outGraphName = null
            )
        {
            Geoprocessor gp = new Geoprocessor();

            StackProfile stackProfile = new StackProfile();


            stackProfile.in_line_features = lineFeatureClass;
            stackProfile.profile_targets = profileSource;
            stackProfile.out_table = outTable;
            if (!string.IsNullOrEmpty(outGraphName)) stackProfile.out_graph = outGraphName;

            GeoProcessorResult gpResult = new GeoProcessorResult();

            gp.SetEnvironmentValue(environmentName, temporaryWorkspace);
            return RunTool(gp, stackProfile, null, messages);
        }
        //-------------------------------------------------------------------------

        public static bool GenerateVisibilityData(
                        string rasterSource,
                        string observerObjectsFeatureClass,
                        VisibilityAnalysisTypesEnum analyzeType,
                        string outRasterName,
                        IEnumerable<string> messages,
                        VisibilityCurvatureCorrectionEnum curvatureCorrection = VisibilityCurvatureCorrectionEnum.FLAT_EARTH,
                        string outAglRaster = null,
                        int innerRadius = 0,
                        int outerRadius = 0
                        )
        {
            Geoprocessor gp = new Geoprocessor();

            Visibility visibility = new Visibility();

            visibility.analysis_type = analyzeType.ToString().ToUpper();
            visibility.in_raster = rasterSource;
            visibility.in_observer_features = observerObjectsFeatureClass;
            visibility.out_raster = outRasterName;
            if (!string.IsNullOrWhiteSpace(outAglRaster))
            {
                visibility.out_agl_raster = outAglRaster;
            }

            visibility.nonvisible_cell_value = NonvisibleCellValue;

            visibility.horizontal_start_angle = VisibilityFieldsEnum.AzimuthB.ToString();
            visibility.horizontal_end_angle = VisibilityFieldsEnum.AzimuthE.ToString();
            visibility.vertical_lower_angle = VisibilityFieldsEnum.AnglMinH.ToString();
            visibility.vertical_upper_angle = VisibilityFieldsEnum.AnglMaxH.ToString();

            if (innerRadius > 0)
            {
                visibility.inner_radius = innerRadius.ToString();
            }
            if (outerRadius > 0)
            {
                visibility.outer_radius = outerRadius.ToString();
            }

            visibility.curvature_correction = curvatureCorrection.ToString();

            GeoProcessorResult gpResult = new GeoProcessorResult();

            gp.SetEnvironmentValue(environmentName, temporaryWorkspace); ;

            return RunTool(gp, visibility, null, messages);
        }

        private static bool RunTool(Geoprocessor gp, IGPProcess process, ITrackCancel TC, IEnumerable<string> messages)
        {
            gp.OverwriteOutput = true; // Set the overwrite output option to true
            bool result = true;
            try
            {
                IGeoProcessorResult pResult = (IGeoProcessorResult)gp.Execute(process, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = false;
            }

            messages = ReturnMessages(gp);
            return result;
        }
        //-------------------------------------------------------------------------
        private static IEnumerable<string> ReturnMessages(Geoprocessor gp)
        {
            if (gp.MessageCount > 0)
            {
                var result = new string[gp.MessageCount];
                for (int count = 0; count < gp.MessageCount; count++)
                {
                    result[count] = gp.GetMessage(count);
                    log.WarnEx(result[count]);
                }
            }
            return null;
        }
    }
}
