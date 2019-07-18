﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MilSpace.DataAccess.Definition
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MilSpaceApp")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMilSp_Visible_ResultIOP(MilSp_Visible_ResultIOP instance);
    partial void UpdateMilSp_Visible_ResultIOP(MilSp_Visible_ResultIOP instance);
    partial void DeleteMilSp_Visible_ResultIOP(MilSp_Visible_ResultIOP instance);
    partial void InsertMilSp_Visible_InstantObservationPoint(MilSp_Visible_InstantObservationPoint instance);
    partial void UpdateMilSp_Visible_InstantObservationPoint(MilSp_Visible_InstantObservationPoint instance);
    partial void DeleteMilSp_Visible_InstantObservationPoint(MilSp_Visible_InstantObservationPoint instance);
    partial void InsertMilSp_Visible_ObjectsObservation_R(MilSp_Visible_ObjectsObservation_R instance);
    partial void UpdateMilSp_Visible_ObjectsObservation_R(MilSp_Visible_ObjectsObservation_R instance);
    partial void DeleteMilSp_Visible_ObjectsObservation_R(MilSp_Visible_ObjectsObservation_R instance);
    partial void InsertMilSp_Visible_ObservPoints_P(MilSp_Visible_ObservPoints_P instance);
    partial void UpdateMilSp_Visible_ObservPoints_P(MilSp_Visible_ObservPoints_P instance);
    partial void DeleteMilSp_Visible_ObservPoints_P(MilSp_Visible_ObservPoints_P instance);
    partial void InsertMilSp_Visible_ResultOO(MilSp_Visible_ResultOO instance);
    partial void UpdateMilSp_Visible_ResultOO(MilSp_Visible_ResultOO instance);
    partial void DeleteMilSp_Visible_ResultOO(MilSp_Visible_ResultOO instance);
    partial void InsertMilSp_Visible_ResultQuality(MilSp_Visible_ResultQuality instance);
    partial void UpdateMilSp_Visible_ResultQuality(MilSp_Visible_ResultQuality instance);
    partial void DeleteMilSp_Visible_ResultQuality(MilSp_Visible_ResultQuality instance);
    partial void InsertMilSp_Visible_ResultIOP1(MilSp_Visible_ResultIOP1 instance);
    partial void UpdateMilSp_Visible_ResultIOP1(MilSp_Visible_ResultIOP1 instance);
    partial void DeleteMilSp_Visible_ResultIOP1(MilSp_Visible_ResultIOP1 instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::MilSpace.DataAccess.Properties.Settings.Default.MilSpaceAppConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<MilSp_Visible_ResultIOP> MilSp_Visible_ResultIOPs
		{
			get
			{
				return this.GetTable<MilSp_Visible_ResultIOP>();
			}
		}
		
		public System.Data.Linq.Table<MilSp_Visible_InstantObservationPoint> MilSp_Visible_InstantObservationPoints
		{
			get
			{
				return this.GetTable<MilSp_Visible_InstantObservationPoint>();
			}
		}
		
		public System.Data.Linq.Table<MilSp_Visible_Result> MilSp_Visible_Results
		{
			get
			{
				return this.GetTable<MilSp_Visible_Result>();
			}
		}
		
		public System.Data.Linq.Table<MilSp_Visible_ResultsCover> MilSp_Visible_ResultsCovers
		{
			get
			{
				return this.GetTable<MilSp_Visible_ResultsCover>();
			}
		}
		
		public System.Data.Linq.Table<MilSp_CL_TypeOP> MilSp_CL_TypeOPs
		{
			get
			{
				return this.GetTable<MilSp_CL_TypeOP>();
			}
		}
		
		public System.Data.Linq.Table<MilSp_Visible_ObjectsObservation_R> MilSp_Visible_ObjectsObservation_Rs
		{
			get
			{
				return this.GetTable<MilSp_Visible_ObjectsObservation_R>();
			}
		}
		
		public System.Data.Linq.Table<MilSp_Visible_ObservPoints_P> MilSp_Visible_ObservPoints_Ps
		{
			get
			{
				return this.GetTable<MilSp_Visible_ObservPoints_P>();
			}
		}
		
		public System.Data.Linq.Table<MilSp_Visible_ResultOO> MilSp_Visible_ResultOOs
		{
			get
			{
				return this.GetTable<MilSp_Visible_ResultOO>();
			}
		}
		
		public System.Data.Linq.Table<MilSp_Visible_ResultQuality> MilSp_Visible_ResultQualities
		{
			get
			{
				return this.GetTable<MilSp_Visible_ResultQuality>();
			}
		}
		
		public System.Data.Linq.Table<MilSp_Visible_ResultIOP1> MilSp_Visible_ResultIOP1s
		{
			get
			{
				return this.GetTable<MilSp_Visible_ResultIOP1>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MilSp_Visible_ResultIOP")]
	public partial class MilSp_Visible_ResultIOP : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _objectid;
		
		private string _idOPRes;
		
		private string _idOP;
		
		private string _idIOP;
		
		private string _idRes;
		
		private System.Nullable<System.DateTime> _DT;
		
		private System.Nullable<double> _XWGS;
		
		private System.Nullable<double> _YWGS;
		
		private System.Nullable<double> _HAbs;
		
		private System.Nullable<double> _Az1;
		
		private System.Nullable<double> _Az2;
		
		private System.Nullable<double> _Angl1;
		
		private System.Nullable<double> _Angl2;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnobjectidChanging(int value);
    partial void OnobjectidChanged();
    partial void OnidOPResChanging(string value);
    partial void OnidOPResChanged();
    partial void OnidOPChanging(string value);
    partial void OnidOPChanged();
    partial void OnidIOPChanging(string value);
    partial void OnidIOPChanged();
    partial void OnidResChanging(string value);
    partial void OnidResChanged();
    partial void OnDTChanging(System.Nullable<System.DateTime> value);
    partial void OnDTChanged();
    partial void OnXWGSChanging(System.Nullable<double> value);
    partial void OnXWGSChanged();
    partial void OnYWGSChanging(System.Nullable<double> value);
    partial void OnYWGSChanged();
    partial void OnHAbsChanging(System.Nullable<double> value);
    partial void OnHAbsChanged();
    partial void OnAz1Changing(System.Nullable<double> value);
    partial void OnAz1Changed();
    partial void OnAz2Changing(System.Nullable<double> value);
    partial void OnAz2Changed();
    partial void OnAngl1Changing(System.Nullable<double> value);
    partial void OnAngl1Changed();
    partial void OnAngl2Changing(System.Nullable<double> value);
    partial void OnAngl2Changed();
    #endregion
		
		public MilSp_Visible_ResultIOP()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_objectid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int objectid
		{
			get
			{
				return this._objectid;
			}
			set
			{
				if ((this._objectid != value))
				{
					this.OnobjectidChanging(value);
					this.SendPropertyChanging();
					this._objectid = value;
					this.SendPropertyChanged("objectid");
					this.OnobjectidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idOPRes", DbType="NVarChar(50)")]
		public string idOPRes
		{
			get
			{
				return this._idOPRes;
			}
			set
			{
				if ((this._idOPRes != value))
				{
					this.OnidOPResChanging(value);
					this.SendPropertyChanging();
					this._idOPRes = value;
					this.SendPropertyChanged("idOPRes");
					this.OnidOPResChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idOP", DbType="NVarChar(50)")]
		public string idOP
		{
			get
			{
				return this._idOP;
			}
			set
			{
				if ((this._idOP != value))
				{
					this.OnidOPChanging(value);
					this.SendPropertyChanging();
					this._idOP = value;
					this.SendPropertyChanged("idOP");
					this.OnidOPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idIOP", DbType="NVarChar(50)")]
		public string idIOP
		{
			get
			{
				return this._idIOP;
			}
			set
			{
				if ((this._idIOP != value))
				{
					this.OnidIOPChanging(value);
					this.SendPropertyChanging();
					this._idIOP = value;
					this.SendPropertyChanged("idIOP");
					this.OnidIOPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idRes", DbType="NVarChar(50)")]
		public string idRes
		{
			get
			{
				return this._idRes;
			}
			set
			{
				if ((this._idRes != value))
				{
					this.OnidResChanging(value);
					this.SendPropertyChanging();
					this._idRes = value;
					this.SendPropertyChanged("idRes");
					this.OnidResChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DT", DbType="DateTime")]
		public System.Nullable<System.DateTime> DT
		{
			get
			{
				return this._DT;
			}
			set
			{
				if ((this._DT != value))
				{
					this.OnDTChanging(value);
					this.SendPropertyChanging();
					this._DT = value;
					this.SendPropertyChanged("DT");
					this.OnDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_XWGS", DbType="Float")]
		public System.Nullable<double> XWGS
		{
			get
			{
				return this._XWGS;
			}
			set
			{
				if ((this._XWGS != value))
				{
					this.OnXWGSChanging(value);
					this.SendPropertyChanging();
					this._XWGS = value;
					this.SendPropertyChanged("XWGS");
					this.OnXWGSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YWGS", DbType="Float")]
		public System.Nullable<double> YWGS
		{
			get
			{
				return this._YWGS;
			}
			set
			{
				if ((this._YWGS != value))
				{
					this.OnYWGSChanging(value);
					this.SendPropertyChanging();
					this._YWGS = value;
					this.SendPropertyChanged("YWGS");
					this.OnYWGSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HAbs", DbType="Float")]
		public System.Nullable<double> HAbs
		{
			get
			{
				return this._HAbs;
			}
			set
			{
				if ((this._HAbs != value))
				{
					this.OnHAbsChanging(value);
					this.SendPropertyChanging();
					this._HAbs = value;
					this.SendPropertyChanged("HAbs");
					this.OnHAbsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Az1", DbType="Float")]
		public System.Nullable<double> Az1
		{
			get
			{
				return this._Az1;
			}
			set
			{
				if ((this._Az1 != value))
				{
					this.OnAz1Changing(value);
					this.SendPropertyChanging();
					this._Az1 = value;
					this.SendPropertyChanged("Az1");
					this.OnAz1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Az2", DbType="Float")]
		public System.Nullable<double> Az2
		{
			get
			{
				return this._Az2;
			}
			set
			{
				if ((this._Az2 != value))
				{
					this.OnAz2Changing(value);
					this.SendPropertyChanging();
					this._Az2 = value;
					this.SendPropertyChanged("Az2");
					this.OnAz2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Angl1", DbType="Float")]
		public System.Nullable<double> Angl1
		{
			get
			{
				return this._Angl1;
			}
			set
			{
				if ((this._Angl1 != value))
				{
					this.OnAngl1Changing(value);
					this.SendPropertyChanging();
					this._Angl1 = value;
					this.SendPropertyChanged("Angl1");
					this.OnAngl1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Angl2", DbType="Float")]
		public System.Nullable<double> Angl2
		{
			get
			{
				return this._Angl2;
			}
			set
			{
				if ((this._Angl2 != value))
				{
					this.OnAngl2Changing(value);
					this.SendPropertyChanging();
					this._Angl2 = value;
					this.SendPropertyChanged("Angl2");
					this.OnAngl2Changed();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MilSp_Visible_InstantObservationPoint")]
	public partial class MilSp_Visible_InstantObservationPoint : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _objectid;
		
		private string _idIOP;
		
		private string _IDOP;
		
		private System.Nullable<double> _HAbs;
		
		private System.Nullable<double> _XWGS;
		
		private System.Nullable<double> _YWGS;
		
		private System.Nullable<double> _Az1;
		
		private System.Nullable<double> _Az2;
		
		private System.Nullable<double> _Angl1;
		
		private System.Nullable<double> _Angl2;
		
		private System.Nullable<double> _Distance;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnobjectidChanging(int value);
    partial void OnobjectidChanged();
    partial void OnidIOPChanging(string value);
    partial void OnidIOPChanged();
    partial void OnIDOPChanging(string value);
    partial void OnIDOPChanged();
    partial void OnHAbsChanging(System.Nullable<double> value);
    partial void OnHAbsChanged();
    partial void OnXWGSChanging(System.Nullable<double> value);
    partial void OnXWGSChanged();
    partial void OnYWGSChanging(System.Nullable<double> value);
    partial void OnYWGSChanged();
    partial void OnAz1Changing(System.Nullable<double> value);
    partial void OnAz1Changed();
    partial void OnAz2Changing(System.Nullable<double> value);
    partial void OnAz2Changed();
    partial void OnAngl1Changing(System.Nullable<double> value);
    partial void OnAngl1Changed();
    partial void OnAngl2Changing(System.Nullable<double> value);
    partial void OnAngl2Changed();
    partial void OnDistanceChanging(System.Nullable<double> value);
    partial void OnDistanceChanged();
    #endregion
		
		public MilSp_Visible_InstantObservationPoint()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_objectid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int objectid
		{
			get
			{
				return this._objectid;
			}
			set
			{
				if ((this._objectid != value))
				{
					this.OnobjectidChanging(value);
					this.SendPropertyChanging();
					this._objectid = value;
					this.SendPropertyChanged("objectid");
					this.OnobjectidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idIOP", DbType="NVarChar(50)")]
		public string idIOP
		{
			get
			{
				return this._idIOP;
			}
			set
			{
				if ((this._idIOP != value))
				{
					this.OnidIOPChanging(value);
					this.SendPropertyChanging();
					this._idIOP = value;
					this.SendPropertyChanged("idIOP");
					this.OnidIOPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDOP", DbType="NChar(50)")]
		public string IDOP
		{
			get
			{
				return this._IDOP;
			}
			set
			{
				if ((this._IDOP != value))
				{
					this.OnIDOPChanging(value);
					this.SendPropertyChanging();
					this._IDOP = value;
					this.SendPropertyChanged("IDOP");
					this.OnIDOPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HAbs", DbType="Float")]
		public System.Nullable<double> HAbs
		{
			get
			{
				return this._HAbs;
			}
			set
			{
				if ((this._HAbs != value))
				{
					this.OnHAbsChanging(value);
					this.SendPropertyChanging();
					this._HAbs = value;
					this.SendPropertyChanged("HAbs");
					this.OnHAbsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_XWGS", DbType="Float")]
		public System.Nullable<double> XWGS
		{
			get
			{
				return this._XWGS;
			}
			set
			{
				if ((this._XWGS != value))
				{
					this.OnXWGSChanging(value);
					this.SendPropertyChanging();
					this._XWGS = value;
					this.SendPropertyChanged("XWGS");
					this.OnXWGSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YWGS", DbType="Float")]
		public System.Nullable<double> YWGS
		{
			get
			{
				return this._YWGS;
			}
			set
			{
				if ((this._YWGS != value))
				{
					this.OnYWGSChanging(value);
					this.SendPropertyChanging();
					this._YWGS = value;
					this.SendPropertyChanged("YWGS");
					this.OnYWGSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Az1", DbType="Float")]
		public System.Nullable<double> Az1
		{
			get
			{
				return this._Az1;
			}
			set
			{
				if ((this._Az1 != value))
				{
					this.OnAz1Changing(value);
					this.SendPropertyChanging();
					this._Az1 = value;
					this.SendPropertyChanged("Az1");
					this.OnAz1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Az2", DbType="Float")]
		public System.Nullable<double> Az2
		{
			get
			{
				return this._Az2;
			}
			set
			{
				if ((this._Az2 != value))
				{
					this.OnAz2Changing(value);
					this.SendPropertyChanging();
					this._Az2 = value;
					this.SendPropertyChanged("Az2");
					this.OnAz2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Angl1", DbType="Float")]
		public System.Nullable<double> Angl1
		{
			get
			{
				return this._Angl1;
			}
			set
			{
				if ((this._Angl1 != value))
				{
					this.OnAngl1Changing(value);
					this.SendPropertyChanging();
					this._Angl1 = value;
					this.SendPropertyChanged("Angl1");
					this.OnAngl1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Angl2", DbType="Float")]
		public System.Nullable<double> Angl2
		{
			get
			{
				return this._Angl2;
			}
			set
			{
				if ((this._Angl2 != value))
				{
					this.OnAngl2Changing(value);
					this.SendPropertyChanging();
					this._Angl2 = value;
					this.SendPropertyChanged("Angl2");
					this.OnAngl2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Distance", DbType="Float")]
		public System.Nullable<double> Distance
		{
			get
			{
				return this._Distance;
			}
			set
			{
				if ((this._Distance != value))
				{
					this.OnDistanceChanging(value);
					this.SendPropertyChanging();
					this._Distance = value;
					this.SendPropertyChanged("Distance");
					this.OnDistanceChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MilSp_Visible_Results")]
	public partial class MilSp_Visible_Result
	{
		
		private int _ObjectID;
		
		private string _IDRes;
		
		private string _TypeRez;
		
		private System.Nullable<int> _ishare;
		
		private System.Nullable<System.DateTime> _dto;
		
		private string _soper;
		
		public MilSp_Visible_Result()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ObjectID", DbType="Int NOT NULL")]
		public int ObjectID
		{
			get
			{
				return this._ObjectID;
			}
			set
			{
				if ((this._ObjectID != value))
				{
					this._ObjectID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDRes", DbType="NVarChar(50)")]
		public string IDRes
		{
			get
			{
				return this._IDRes;
			}
			set
			{
				if ((this._IDRes != value))
				{
					this._IDRes = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TypeRez", DbType="NVarChar(10)")]
		public string TypeRez
		{
			get
			{
				return this._TypeRez;
			}
			set
			{
				if ((this._TypeRez != value))
				{
					this._TypeRez = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ishare", DbType="Int")]
		public System.Nullable<int> ishare
		{
			get
			{
				return this._ishare;
			}
			set
			{
				if ((this._ishare != value))
				{
					this._ishare = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dto", DbType="DateTime")]
		public System.Nullable<System.DateTime> dto
		{
			get
			{
				return this._dto;
			}
			set
			{
				if ((this._dto != value))
				{
					this._dto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soper", DbType="NVarChar(50)")]
		public string soper
		{
			get
			{
				return this._soper;
			}
			set
			{
				if ((this._soper != value))
				{
					this._soper = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MilSp_Visible_ResultsCover")]
	public partial class MilSp_Visible_ResultsCover
	{
		
		private int _objectid;
		
		private string _idCover;
		
		private string _IDRes;
		
		private string _LnkToCover;
		
		private System.Nullable<int> _ColorCover;
		
		private System.Nullable<int> _NoDataCover;
		
		public MilSp_Visible_ResultsCover()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_objectid", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int objectid
		{
			get
			{
				return this._objectid;
			}
			set
			{
				if ((this._objectid != value))
				{
					this._objectid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCover", DbType="NVarChar(50)")]
		public string idCover
		{
			get
			{
				return this._idCover;
			}
			set
			{
				if ((this._idCover != value))
				{
					this._idCover = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDRes", DbType="NVarChar(50)")]
		public string IDRes
		{
			get
			{
				return this._IDRes;
			}
			set
			{
				if ((this._IDRes != value))
				{
					this._IDRes = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LnkToCover", DbType="NVarChar(255)")]
		public string LnkToCover
		{
			get
			{
				return this._LnkToCover;
			}
			set
			{
				if ((this._LnkToCover != value))
				{
					this._LnkToCover = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ColorCover", DbType="Int")]
		public System.Nullable<int> ColorCover
		{
			get
			{
				return this._ColorCover;
			}
			set
			{
				if ((this._ColorCover != value))
				{
					this._ColorCover = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoDataCover", DbType="Int")]
		public System.Nullable<int> NoDataCover
		{
			get
			{
				return this._NoDataCover;
			}
			set
			{
				if ((this._NoDataCover != value))
				{
					this._NoDataCover = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MilSp_CL_TypeOP")]
	public partial class MilSp_CL_TypeOP
	{
		
		private System.Nullable<int> _objectid;
		
		private string _TypeOP;
		
		private string _sTitle;
		
		public MilSp_CL_TypeOP()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_objectid", DbType="Int")]
		public System.Nullable<int> objectid
		{
			get
			{
				return this._objectid;
			}
			set
			{
				if ((this._objectid != value))
				{
					this._objectid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TypeOP", DbType="NVarChar(10)")]
		public string TypeOP
		{
			get
			{
				return this._TypeOP;
			}
			set
			{
				if ((this._TypeOP != value))
				{
					this._TypeOP = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sTitle", DbType="NVarChar(50)")]
		public string sTitle
		{
			get
			{
				return this._sTitle;
			}
			set
			{
				if ((this._sTitle != value))
				{
					this._sTitle = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MilSp_Visible_ObjectsObservation_R")]
	public partial class MilSp_Visible_ObjectsObservation_R : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idobjects;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidobjectsChanging(int value);
    partial void OnidobjectsChanged();
    #endregion
		
		public MilSp_Visible_ObjectsObservation_R()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idobjects", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idobjects
		{
			get
			{
				return this._idobjects;
			}
			set
			{
				if ((this._idobjects != value))
				{
					this.OnidobjectsChanging(value);
					this.SendPropertyChanging();
					this._idobjects = value;
					this.SendPropertyChanged("idobjects");
					this.OnidobjectsChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MilSp_Visible_ObservPoints_P")]
	public partial class MilSp_Visible_ObservPoints_P : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _objectid;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnobjectidChanging(int value);
    partial void OnobjectidChanged();
    #endregion
		
		public MilSp_Visible_ObservPoints_P()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_objectid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int objectid
		{
			get
			{
				return this._objectid;
			}
			set
			{
				if ((this._objectid != value))
				{
					this.OnobjectidChanging(value);
					this.SendPropertyChanging();
					this._objectid = value;
					this.SendPropertyChanged("objectid");
					this.OnobjectidChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MilSp_Visible_ResultOO")]
	public partial class MilSp_Visible_ResultOO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _objectid;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnobjectidChanging(int value);
    partial void OnobjectidChanged();
    #endregion
		
		public MilSp_Visible_ResultOO()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_objectid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int objectid
		{
			get
			{
				return this._objectid;
			}
			set
			{
				if ((this._objectid != value))
				{
					this.OnobjectidChanging(value);
					this.SendPropertyChanging();
					this._objectid = value;
					this.SendPropertyChanged("objectid");
					this.OnobjectidChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MilSp_Visible_ResultQuality")]
	public partial class MilSp_Visible_ResultQuality : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _objectid;
		
		private string _idResQual;
		
		private string _idRes;
		
		private string _IDOORes;
		
		private string _IDOPRes;
		
		private string _TypeQual;
		
		private System.Nullable<double> _EvalQual;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnobjectidChanging(int value);
    partial void OnobjectidChanged();
    partial void OnidResQualChanging(string value);
    partial void OnidResQualChanged();
    partial void OnidResChanging(string value);
    partial void OnidResChanged();
    partial void OnIDOOResChanging(string value);
    partial void OnIDOOResChanged();
    partial void OnIDOPResChanging(string value);
    partial void OnIDOPResChanged();
    partial void OnTypeQualChanging(string value);
    partial void OnTypeQualChanged();
    partial void OnEvalQualChanging(System.Nullable<double> value);
    partial void OnEvalQualChanged();
    #endregion
		
		public MilSp_Visible_ResultQuality()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_objectid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int objectid
		{
			get
			{
				return this._objectid;
			}
			set
			{
				if ((this._objectid != value))
				{
					this.OnobjectidChanging(value);
					this.SendPropertyChanging();
					this._objectid = value;
					this.SendPropertyChanged("objectid");
					this.OnobjectidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idResQual", DbType="NVarChar(50)")]
		public string idResQual
		{
			get
			{
				return this._idResQual;
			}
			set
			{
				if ((this._idResQual != value))
				{
					this.OnidResQualChanging(value);
					this.SendPropertyChanging();
					this._idResQual = value;
					this.SendPropertyChanged("idResQual");
					this.OnidResQualChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idRes", DbType="NVarChar(50)")]
		public string idRes
		{
			get
			{
				return this._idRes;
			}
			set
			{
				if ((this._idRes != value))
				{
					this.OnidResChanging(value);
					this.SendPropertyChanging();
					this._idRes = value;
					this.SendPropertyChanged("idRes");
					this.OnidResChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDOORes", DbType="NVarChar(50)")]
		public string IDOORes
		{
			get
			{
				return this._IDOORes;
			}
			set
			{
				if ((this._IDOORes != value))
				{
					this.OnIDOOResChanging(value);
					this.SendPropertyChanging();
					this._IDOORes = value;
					this.SendPropertyChanged("IDOORes");
					this.OnIDOOResChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDOPRes", DbType="NVarChar(50)")]
		public string IDOPRes
		{
			get
			{
				return this._IDOPRes;
			}
			set
			{
				if ((this._IDOPRes != value))
				{
					this.OnIDOPResChanging(value);
					this.SendPropertyChanging();
					this._IDOPRes = value;
					this.SendPropertyChanged("IDOPRes");
					this.OnIDOPResChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TypeQual", DbType="NVarChar(10)")]
		public string TypeQual
		{
			get
			{
				return this._TypeQual;
			}
			set
			{
				if ((this._TypeQual != value))
				{
					this.OnTypeQualChanging(value);
					this.SendPropertyChanging();
					this._TypeQual = value;
					this.SendPropertyChanged("TypeQual");
					this.OnTypeQualChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EvalQual", DbType="Float")]
		public System.Nullable<double> EvalQual
		{
			get
			{
				return this._EvalQual;
			}
			set
			{
				if ((this._EvalQual != value))
				{
					this.OnEvalQualChanging(value);
					this.SendPropertyChanging();
					this._EvalQual = value;
					this.SendPropertyChanged("EvalQual");
					this.OnEvalQualChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MilSp_Visible_ResultIOP")]
	public partial class MilSp_Visible_ResultIOP1 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _objectid;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnobjectidChanging(int value);
    partial void OnobjectidChanged();
    #endregion
		
		public MilSp_Visible_ResultIOP1()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_objectid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int objectid
		{
			get
			{
				return this._objectid;
			}
			set
			{
				if ((this._objectid != value))
				{
					this.OnobjectidChanging(value);
					this.SendPropertyChanging();
					this._objectid = value;
					this.SendPropertyChanged("objectid");
					this.OnobjectidChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591