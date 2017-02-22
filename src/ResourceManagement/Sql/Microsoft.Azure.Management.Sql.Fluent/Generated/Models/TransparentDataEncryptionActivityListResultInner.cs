// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Represents the response to a List Azure SQL Database Transparent Data
    /// Encryption Activity request.
    /// </summary>
    public partial class TransparentDataEncryptionActivityListResultInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// TransparentDataEncryptionActivityListResultInner class.
        /// </summary>
        public TransparentDataEncryptionActivityListResultInner() { }

        /// <summary>
        /// Initializes a new instance of the
        /// TransparentDataEncryptionActivityListResultInner class.
        /// </summary>
        /// <param name="value">The list of Azure SQL Database Transparent
        /// Data Encryption Activities.</param>
        public TransparentDataEncryptionActivityListResultInner(System.Collections.Generic.IList<TransparentDataEncryptionActivity> value)
        {
            Value = value;
        }

        /// <summary>
        /// Gets or sets the list of Azure SQL Database Transparent Data
        /// Encryption Activities.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<TransparentDataEncryptionActivity> Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Value == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Value");
            }
        }
    }
}