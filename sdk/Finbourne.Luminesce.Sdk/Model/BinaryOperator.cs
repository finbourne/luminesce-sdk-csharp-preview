/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.13.390
 * Contact: info@finbourne.com
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
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Finbourne.Luminesce.Sdk.Client.OpenAPIDateConverter;

namespace Finbourne.Luminesce.Sdk.Model
{
    /// <summary>
    /// Defines BinaryOperator
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum BinaryOperator
    {
        /// <summary>
        /// Enum And for value: And
        /// </summary>
        [EnumMember(Value = "And")]
        And = 1,

        /// <summary>
        /// Enum Or for value: Or
        /// </summary>
        [EnumMember(Value = "Or")]
        Or = 2,

        /// <summary>
        /// Enum Add for value: Add
        /// </summary>
        [EnumMember(Value = "Add")]
        Add = 3,

        /// <summary>
        /// Enum Subtract for value: Subtract
        /// </summary>
        [EnumMember(Value = "Subtract")]
        Subtract = 4,

        /// <summary>
        /// Enum Multiply for value: Multiply
        /// </summary>
        [EnumMember(Value = "Multiply")]
        Multiply = 5,

        /// <summary>
        /// Enum Divide for value: Divide
        /// </summary>
        [EnumMember(Value = "Divide")]
        Divide = 6,

        /// <summary>
        /// Enum Mod for value: Mod
        /// </summary>
        [EnumMember(Value = "Mod")]
        Mod = 7,

        /// <summary>
        /// Enum Lt for value: Lt
        /// </summary>
        [EnumMember(Value = "Lt")]
        Lt = 8,

        /// <summary>
        /// Enum Lte for value: Lte
        /// </summary>
        [EnumMember(Value = "Lte")]
        Lte = 9,

        /// <summary>
        /// Enum Gt for value: Gt
        /// </summary>
        [EnumMember(Value = "Gt")]
        Gt = 10,

        /// <summary>
        /// Enum Gte for value: Gte
        /// </summary>
        [EnumMember(Value = "Gte")]
        Gte = 11,

        /// <summary>
        /// Enum Eq for value: Eq
        /// </summary>
        [EnumMember(Value = "Eq")]
        Eq = 12,

        /// <summary>
        /// Enum Neq for value: Neq
        /// </summary>
        [EnumMember(Value = "Neq")]
        Neq = 13,

        /// <summary>
        /// Enum In for value: In
        /// </summary>
        [EnumMember(Value = "In")]
        In = 14,

        /// <summary>
        /// Enum NotIn for value: NotIn
        /// </summary>
        [EnumMember(Value = "NotIn")]
        NotIn = 15,

        /// <summary>
        /// Enum Is for value: Is
        /// </summary>
        [EnumMember(Value = "Is")]
        Is = 16,

        /// <summary>
        /// Enum IsNot for value: IsNot
        /// </summary>
        [EnumMember(Value = "IsNot")]
        IsNot = 17,

        /// <summary>
        /// Enum BitShiftLeft for value: BitShiftLeft
        /// </summary>
        [EnumMember(Value = "BitShiftLeft")]
        BitShiftLeft = 18,

        /// <summary>
        /// Enum BitShiftRight for value: BitShiftRight
        /// </summary>
        [EnumMember(Value = "BitShiftRight")]
        BitShiftRight = 19,

        /// <summary>
        /// Enum BitwiseAnd for value: BitwiseAnd
        /// </summary>
        [EnumMember(Value = "BitwiseAnd")]
        BitwiseAnd = 20,

        /// <summary>
        /// Enum BitwiseOr for value: BitwiseOr
        /// </summary>
        [EnumMember(Value = "BitwiseOr")]
        BitwiseOr = 21,

        /// <summary>
        /// Enum Concatenate for value: Concatenate
        /// </summary>
        [EnumMember(Value = "Concatenate")]
        Concatenate = 22,

        /// <summary>
        /// Enum Like for value: Like
        /// </summary>
        [EnumMember(Value = "Like")]
        Like = 23,

        /// <summary>
        /// Enum NotLike for value: NotLike
        /// </summary>
        [EnumMember(Value = "NotLike")]
        NotLike = 24,

        /// <summary>
        /// Enum Glob for value: Glob
        /// </summary>
        [EnumMember(Value = "Glob")]
        Glob = 25,

        /// <summary>
        /// Enum NotGlob for value: NotGlob
        /// </summary>
        [EnumMember(Value = "NotGlob")]
        NotGlob = 26,

        /// <summary>
        /// Enum Regexp for value: Regexp
        /// </summary>
        [EnumMember(Value = "Regexp")]
        Regexp = 27,

        /// <summary>
        /// Enum NotRegexp for value: NotRegexp
        /// </summary>
        [EnumMember(Value = "NotRegexp")]
        NotRegexp = 28

    }

}
