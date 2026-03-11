using OSDC.DotnetLibraries.General.DataManagement;
using System;
using System.Collections.Generic;

namespace NORCE.Drilling.GeothermalProperties.Model
{   


    public class GeothermalPropertiesCompletionOrder : GeothermalPropertiesCompletionOrderLight 
    {
        /// <summary>
        /// a MetaInfo for the GeothermalPropertiesCompletionOrder
        /// </summary>
        public MetaInfo? MetaInfo { get; set; }

        /// <summary>
        /// name of the data
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// a description of the data
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// the date when the data was created
        /// </summary>
        public DateTimeOffset? CreationDate { get; set; }

        /// <summary>
        /// the date when the data was last modified
        /// </summary>
        public DateTimeOffset? LastModificationDate { get; set; }
    
        /// <summary>
        /// an input list of GeothermalProperties
        /// </summary>
        public GeothermalProperties? ReferenceGeothermalProperties { get; set; }
        /// <summary>
        /// an output list of GeothermalProperties
        /// </summary>
        public GeothermalProperties CompletedGeothermalProperties { get; set; }
        /// <summary>
        /// The vertical depth step for interpolation
        /// </summary>
        public double InterpolationStep { get; set; }

        /// <summary>
        /// an output parameter, result of the Calculate() method
        /// </summary>
        public CompletionMethod CompletionMethod {get; set;} = CompletionMethod.LinearInterpolation;
        /// <summary>
        /// default constructor required for JSON serialization
        /// </summary>
        public GeothermalPropertiesCompletionOrder() : base()
        {
        }

        /// <summary>
        /// main calculation method of the GeothermalPropertiesCompletionOrder
        /// </summary>
        /// <returns></returns>
        public bool Calculate()
        {
            bool success = false;
            if (ReferenceGeothermalProperties != null)
            {
        
                success = true;
            }
            return success;
        }
    }
}
