// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Triangle
    /// </summary>
    public partial class Triangle : IEquatable<Triangle>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle" /> class.
        /// </summary>
        /// <param name="equilateralTriangle"></param>
        /// <param name="shapeType">shapeType (required)</param>
        /// <param name="triangleType">triangleType (required)</param>
        public Triangle(EquilateralTriangle equilateralTriangle, string shapeType, string triangleType)
        {
            if (shapeType == null)
                throw new ArgumentNullException("shapeType is a required property for Triangle and cannot be null.");

            if (triangleType == null)
                throw new ArgumentNullException("triangleType is a required property for Triangle and cannot be null.");

            EquilateralTriangle = equilateralTriangle;
            ShapeType = shapeType;
            TriangleType = triangleType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle" /> class.
        /// </summary>
        /// <param name="isoscelesTriangle"></param>
        /// <param name="shapeType">shapeType (required)</param>
        /// <param name="triangleType">triangleType (required)</param>
        public Triangle(IsoscelesTriangle isoscelesTriangle, string shapeType, string triangleType)
        {
            if (shapeType == null)
                throw new ArgumentNullException("shapeType is a required property for Triangle and cannot be null.");

            if (triangleType == null)
                throw new ArgumentNullException("triangleType is a required property for Triangle and cannot be null.");

            IsoscelesTriangle = isoscelesTriangle;
            ShapeType = shapeType;
            TriangleType = triangleType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle" /> class.
        /// </summary>
        /// <param name="scaleneTriangle"></param>
        /// <param name="shapeType">shapeType (required)</param>
        /// <param name="triangleType">triangleType (required)</param>
        public Triangle(ScaleneTriangle scaleneTriangle, string shapeType, string triangleType)
        {
            if (shapeType == null)
                throw new ArgumentNullException("shapeType is a required property for Triangle and cannot be null.");

            if (triangleType == null)
                throw new ArgumentNullException("triangleType is a required property for Triangle and cannot be null.");

            ScaleneTriangle = scaleneTriangle;
            ShapeType = shapeType;
            TriangleType = triangleType;
        }

        /// <summary>
        /// Gets or Sets EquilateralTriangle
        /// </summary>
        public EquilateralTriangle EquilateralTriangle { get; set; }

        /// <summary>
        /// Gets or Sets IsoscelesTriangle
        /// </summary>
        public IsoscelesTriangle IsoscelesTriangle { get; set; }

        /// <summary>
        /// Gets or Sets ScaleneTriangle
        /// </summary>
        public ScaleneTriangle ScaleneTriangle { get; set; }

        /// <summary>
        /// Gets or Sets ShapeType
        /// </summary>
        [JsonPropertyName("shapeType")]
        public string ShapeType { get; set; }

        /// <summary>
        /// Gets or Sets TriangleType
        /// </summary>
        [JsonPropertyName("triangleType")]
        public string TriangleType { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; set; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Triangle {\n");
            sb.Append("  ShapeType: ").Append(ShapeType).Append("\n");
            sb.Append("  TriangleType: ").Append(TriangleType).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input as Triangle).AreEqual;
        }

        /// <summary>
        /// Returns true if Triangle instances are equal
        /// </summary>
        /// <param name="input">Instance of Triangle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Triangle input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ShapeType != null)
                {
                    hashCode = (hashCode * 59) + this.ShapeType.GetHashCode();
                }
                if (this.TriangleType != null)
                {
                    hashCode = (hashCode * 59) + this.TriangleType.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type Triangle
    /// </summary>
    public class TriangleJsonConverter : JsonConverter<Triangle>
    {
        /// <summary>
        /// Returns a boolean if the type is compatible with this converter.
        /// </summary>
        /// <param name="typeToConvert"></param>
        /// <returns></returns>
        public override bool CanConvert(Type typeToConvert) => typeof(Triangle).IsAssignableFrom(typeToConvert);

        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Triangle Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException();

            Utf8JsonReader equilateralTriangleReader = reader;
            bool equilateralTriangleDeserialized = Client.ClientUtils.TryDeserialize<EquilateralTriangle>(ref equilateralTriangleReader, options, out EquilateralTriangle equilateralTriangle);

            Utf8JsonReader isoscelesTriangleReader = reader;
            bool isoscelesTriangleDeserialized = Client.ClientUtils.TryDeserialize<IsoscelesTriangle>(ref isoscelesTriangleReader, options, out IsoscelesTriangle isoscelesTriangle);

            Utf8JsonReader scaleneTriangleReader = reader;
            bool scaleneTriangleDeserialized = Client.ClientUtils.TryDeserialize<ScaleneTriangle>(ref scaleneTriangleReader, options, out ScaleneTriangle scaleneTriangle);

            string shapeType = default;
            string triangleType = default;

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject && currentDepth == reader.CurrentDepth)
                    break;

                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    string propertyName = reader.GetString();
                    reader.Read();

                    switch (propertyName)
                    {
                        case "shapeType":
                            shapeType = reader.GetString();
                            break;
                        case "triangleType":
                            triangleType = reader.GetString();
                            break;
                    }
                }
            }

            if (equilateralTriangleDeserialized)
                return new Triangle(equilateralTriangle, shapeType, triangleType);

            if (isoscelesTriangleDeserialized)
                return new Triangle(isoscelesTriangle, shapeType, triangleType);

            if (scaleneTriangleDeserialized)
                return new Triangle(scaleneTriangle, shapeType, triangleType);

            throw new JsonException();
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="triangle"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Triangle triangle, JsonSerializerOptions options) => throw new NotImplementedException();
    }
}