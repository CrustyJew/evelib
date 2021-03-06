﻿// ***********************************************************************
// Assembly         : EveLib.EveMarketData
// Author           : Lars Kristian
// Created          : 03-06-2014
//
// Last Modified By : Lars Kristian
// Last Modified On : 06-19-2014
// ***********************************************************************
// <copyright file="EmdItemOrdersJsonConverter.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using eZet.EveLib.EveMarketDataModule.Models;
using Newtonsoft.Json;

namespace eZet.EveLib.EveMarketDataModule.JsonConverters {
    /// <summary>
    ///     Class EmdItemOrderJsonConverter.
    /// </summary>
    public class EmdItemOrderJsonConverter : JsonConverter {
        /// <summary>
        ///     Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The <see cref="T:Newtonsoft.Json.JsonWriter" /> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The <see cref="T:Newtonsoft.Json.JsonReader" /> to read from.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <returns>The object value.</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer) {
            var result = new ItemOrders();
            serializer.Converters.Add(new EmdRowCollectionJsonConverter<ItemOrders.ItemOrderEntry>());
            result.Orders = serializer.Deserialize<EmdRowCollection<ItemOrders.ItemOrderEntry>>(reader);
            return result;
        }

        /// <summary>
        ///     Determines whether this instance can convert the specified object type.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <returns>
        ///     <c>true</c> if this instance can convert the specified object type; otherwise,
        ///     <c>false</c>.
        /// </returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public override bool CanConvert(Type objectType) {
            throw new NotImplementedException();
        }
    }
}