#pragma warning disable 1587
/**
 * Copyright 2024 Wingify Software Pvt. Ltd.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *    http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
#pragma warning restore 1587

using Newtonsoft.Json;

namespace VWOFmeSdk.Models.Request
{
    public class EventArchData
    {
        [JsonProperty("msgId")]
        public string MsgId { get; set; }

        [JsonProperty("visId")]
        public string VisId { get; set; }

        [JsonProperty("sessionId")]
        public long SessionId { get; set; }

        [JsonProperty("event")]
        public Event Event { get; set; }

        [JsonProperty("visitor")]
        public Visitor.Visitor Visitor { get; set; }

        [JsonProperty("visitorUa")]
        public string VisitorUa { get; set; }

        [JsonProperty("visitorIp")]
        public string VisitorIp { get; set; }
    }
}
