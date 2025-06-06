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
#pragma warning restore 1587

using System;
using VWOFmeSdk.Services;

namespace VWOFmeSdk.Services
{
    public static class UrlService
    {
        private static string collectionPrefix;

        /**
         * Initializes the UrlService with the collectionPrefix and gatewayService
         * @param collectionPrefix  collectionPrefix to be used in the URL
         */
        public static void Init(string collectionPrefix)
        {
            if (!string.IsNullOrEmpty(collectionPrefix))
            {
                UrlService.collectionPrefix = collectionPrefix;
            }
        }

        /**
         * Returns the base URL for the API requests
         */
        public static string GetBaseUrl()
        {
            string baseUrl = SettingsManager.GetInstance().hostname;

            if (SettingsManager.GetInstance().isGatewayServiceProvided)
            {
                return baseUrl;
            }

            // Construct URL with collectionPrefix if it exists
            if (!string.IsNullOrEmpty(UrlService.collectionPrefix))
            {
                return baseUrl + "/" + UrlService.collectionPrefix;
            }

            return baseUrl;
        }
    }
}
