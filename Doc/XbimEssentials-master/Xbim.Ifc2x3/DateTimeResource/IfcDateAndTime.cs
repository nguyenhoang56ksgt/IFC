// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.PropertyResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.DateTimeResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcDateAndTime
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcDateAndTime : IPersistEntity, IfcDateTimeSelect, IfcObjectReferenceSelect
	{
		IIfcCalendarDate @DateComponent { get;  set; }
		IIfcLocalTime @TimeComponent { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.DateTimeResource
{
	[ExpressType("IfcDateAndTime", 373)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDateAndTime : PersistEntity, IInstantiableEntity, IIfcDateAndTime, IContainsEntityReferences, IEquatable<@IfcDateAndTime>
	{
		#region IIfcDateAndTime explicit implementation
		IIfcCalendarDate IIfcDateAndTime.DateComponent { 
 
 
			get { return @DateComponent; } 
			set { DateComponent = value as IfcCalendarDate;}
		}	
		IIfcLocalTime IIfcDateAndTime.TimeComponent { 
 
 
			get { return @TimeComponent; } 
			set { TimeComponent = value as IfcLocalTime;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDateAndTime(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcCalendarDate _dateComponent;
		private IfcLocalTime _timeComponent;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 1)]
		public IfcCalendarDate @DateComponent 
		{ 
			get 
			{
				if(_activated) return _dateComponent;
				Activate();
				return _dateComponent;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _dateComponent = v, _dateComponent, value,  "DateComponent", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 2)]
		public IfcLocalTime @TimeComponent 
		{ 
			get 
			{
				if(_activated) return _timeComponent;
				Activate();
				return _timeComponent;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _timeComponent = v, _timeComponent, value,  "TimeComponent", 2);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_dateComponent = (IfcCalendarDate)(value.EntityVal);
					return;
				case 1: 
					_timeComponent = (IfcLocalTime)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcDateAndTime other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@DateComponent != null)
					yield return @DateComponent;
				if (@TimeComponent != null)
					yield return @TimeComponent;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}