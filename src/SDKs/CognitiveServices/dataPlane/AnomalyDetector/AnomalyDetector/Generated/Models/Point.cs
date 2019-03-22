// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.AnomalyDetector.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Point
    {
        /// <summary>
        /// Initializes a new instance of the Point class.
        /// </summary>
        public Point()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Point class.
        /// </summary>
        /// <param name="timestamp">Timestamp of a data point (ISO8601
        /// format).</param>
        /// <param name="value">The measurement of that point, should be
        /// float.</param>
        public Point(System.DateTime timestamp, double value)
        {
            Timestamp = timestamp;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets timestamp of a data point (ISO8601 format).
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public System.DateTime Timestamp { get; set; }

        /// <summary>
        /// Gets or sets the measurement of that point, should be float.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public double Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}