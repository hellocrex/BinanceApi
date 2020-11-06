﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PoissonSoft.BinanceApi.Contracts.Enums;
using PoissonSoft.BinanceApi.Contracts.Serialization;

namespace PoissonSoft.BinanceApi.Contracts
{
    /// <summary>
    /// Order
    /// </summary>
    public class BinanceOrder
    {
        /// <summary>
        /// "symbol": "LTCBTC",
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// "orderId": 1,
        /// </summary>
        [JsonProperty("orderId")]
        public long OrderId { get; set; }

        /// <summary>
        /// "orderListId": -1, // Unless OCO, the value will always be -1
        /// </summary>
        [JsonProperty("orderListId")]
        public long OrderListId { get; set; }

        /// <summary>
        /// "clientOrderId": "myOrder1",
        /// </summary>
        [JsonProperty("clientOrderId")]
        public string ClientOrderId { get; set; }

        /// <summary>
        /// "price": "0.1",
        /// </summary>
        [JsonProperty("price")]
        public decimal Price { get; set; }

        /// <summary>
        /// "origQty": "1.0",
        /// </summary>
        [JsonProperty("origQty")]
        public decimal OriginalQuantity { get; set; }

        /// <summary>
        /// "executedQty": "0.0",
        /// </summary>
        [JsonProperty(PropertyName = "executedQty")]
        public decimal ExecutedQuantity { get; set; }

        /// <summary>
        /// "cummulativeQuoteQty": "0.0",
        /// </summary>
        [JsonProperty(PropertyName = "cummulativeQuoteQty")]
        public decimal CumulativeQuoteQuantity { get; set; }

        /// <summary>
        /// "status": "NEW",
        /// </summary>
        [JsonConverter(typeof(StringEnumExConverter), OrderStatus.Unknown)]
        public OrderStatus Status { get; set; }

        /// <summary>
        /// Time in force
        /// "timeInForce": "GTC",
        /// </summary>
        [JsonProperty("timeInForce")]
        [JsonConverter(typeof(StringEnumExConverter), TimeInForce.Unknown)]
        public TimeInForce TimeInForce { get; set; }

        /// <summary>
        /// Order type
        /// "type": "LIMIT",
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumExConverter), OrderType.Unknown)]
        public OrderType OrderType { get; set; }

        /// <summary>
        /// Side
        /// "side": "BUY",
        /// </summary>
        [JsonProperty("side")]
        [JsonConverter(typeof(StringEnumExConverter), OrderSide.Unknown)]
        public OrderSide Side { get; set; }

        /// <summary>
        /// Stop price
        /// "stopPrice": "0.0", 
        /// </summary>
        [JsonProperty("stopPrice")]
        public decimal StopPrice { get; set; }

        /// <summary>
        /// Iceberg quantity
        /// "icebergQty": "0.0", 
        /// </summary>
        [JsonProperty("icebergQty")]
        public decimal IcebergQuantity { get; set; }

        /// <summary>
        /// Order create time
        /// "time": 1499827319559,
        /// </summary>
        [JsonProperty("time")]
        public long Time { get; set; }

        /// <summary>
        /// Order update time
        /// "updateTime": 1499827319559,
        /// </summary>
        [JsonProperty("updateTime")]
        public long UpdateTime { get; set; }

        /// <summary>
        /// Is this order in the book?
        /// "isWorking": true,
        /// </summary>
        [JsonProperty("isWorking")]
        public bool IsWorking { get; set; }

        /// <summary>
        /// Original quantity in quote asset
        /// "origQuoteOrderQty": "0.000000" 
        /// </summary>
        [JsonProperty("origQuoteOrderQty")]
        public decimal OriginalQuoteOrderQuantity { get; set; }
    }
}
