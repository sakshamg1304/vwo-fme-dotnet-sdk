#pragma warning disable 1587
/**
 * Copyright 2024-2025 Wingify Software Pvt. Ltd.
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
#pragma warning disable 1587

using System.Collections.Generic;

namespace VWOFmeSdk.Packages.NetworkLayer.Models
{
    public class ResponseModel
    {
        private int statusCode;
        private object error;
        private Dictionary<string, string> headers;
        private string data;

        public void SetStatusCode(int statusCode)
        {
            this.statusCode = statusCode;
        }

        public void SetHeaders(Dictionary<string, string> headers)
        {
            this.headers = headers;
        }

        public void SetData(string data)
        {
            this.data = data;
        }

        public void SetError(object error)
        {
            this.error = error;
        }

        public Dictionary<string, string> GetHeaders()
        {
            return headers;
        }

        public string GetData()
        {
            return data;
        }

        public int GetStatusCode()
        {
            return statusCode;
        }

        public object GetError()
        {
            return error;
        }
    }
}
