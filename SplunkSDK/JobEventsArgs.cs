﻿/*
 * Copyright 2012 Splunk, Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License"): you may
 * not use this file except in compliance with the License. You may obtain
 * a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations
 * under the License.
 */

namespace Splunk
{
    /// <summary>
    /// The <see cref="JobEventsArgs"/> class contains arguments for 
    /// getting job results using the <see cref="Job.Events(JobEventsArgs)" />
    /// method.
    /// </summary>
    public class JobEventsArgs : Args
    {
        /// <summary>
        /// Specifies the format for the returned output.
        /// </summary>
        // C# disallows nested class from having the same name as
        // a property. Use 'Enum' suffix to differentiate.
        public enum OutputModeEnum
        {
            /// <summary>
            /// Returns output in Atom format.
            /// </summary>
            [SplunkEnumValue("atom")]
            Atom,

            /// <summary>
            /// Returns output in CSV format.
            /// </summary>
            [SplunkEnumValue("csv")]
            Csv,

            /// <summary>
            /// Returns output in JSON format.
            /// </summary>
            [SplunkEnumValue("json")]
            Json,

            /// <summary>
            /// Returns output in JSON_COLS format.
            /// </summary>
            [SplunkEnumValue("json_cols")]
            JsonColumns,

            /// <summary>
            /// Returns output in JSON_ROWS format.
            /// </summary>
            [SplunkEnumValue("json_rows")]
            JsonRows,

            /// <summary>
            /// Returns output in raw format.
            /// </summary>
            [SplunkEnumValue("raw")]
            Raw,

            /// <summary>
            /// Returns output in XML format.
            /// </summary>
            [SplunkEnumValue("xml")]
            Xml,
        }

        /// <summary>
        /// Specifies how to truncate lines to achieve the value in 
        /// <see cref="MaximumLines"/>
        /// </summary>
        // C# disallows nested classes from having the same name as
        // a property. Use 'Enum' suffix to differentiate.
        public enum TruncationModeEnum
        {
            /// <summary>
            /// Use the "abstract" truncation mode.
            /// </summary>
            [SplunkEnumValue("abstract")]
            Abstract,

            /// <summary>
            /// Use the "truncate" truncation mode.
            /// </summary>
            [SplunkEnumValue("truncate")]
            Truncate,
        }

        /* BEGIN AUTOGENERATED CODE */

        /// <summary>
        /// Sets the maximum number of results to return.  
        /// </summary>
        /// <remarks>
        /// <para>
        /// To return all available results, set this property to "0".
        /// </para>
        /// <para>
        /// This property's default value is "100".
        /// </para>
        /// </remarks>
        public new int Count
        {
            set { this["count"] = value; }
        }

        /// <summary>
        /// Sets the earliest time in the time range to search. 
        /// </summary>
        /// <remarks>
        /// <para>
        /// This property's value is a time string. The time string can be a 
        /// UTC time (with fractional seconds), a relative time specifier (to
        /// now), or a formatted time string.
        /// </para>
        /// </remarks>
        public string EarliestTime
        {
            set { this["earliest_time"] = value; }
        }

        /// <summary>
        /// Sets a list of fields to return for the event set.
        /// </summary>
        public string[] FieldList
        {
            set { this["f"] = value; }
        }

        /// <summary>
        /// Sets the latest time in the time range to search. 
        /// </summary>
        /// <remarks>
        /// <para>
        /// This property's value is a time string. The time string can be a UTC
        /// time (with fractional seconds), a relative time specifier (to now),
        /// or a formatted time string.
        /// </para>
        /// </remarks>
        public string LatestTime
        {
            set { this["latest_time"] = value; }
        }

        /// <summary>
        /// Sets the maximum number of lines that any single event's 
        /// <b>_raw</b> field should contain.
        /// </summary>
        public int MaximumLines
        {
            set { this["max_lines"] = value; }
        }

        /// <summary>
        /// Sets the index of the first result (inclusive) from which to begin
        /// returning data. This value is 0-indexed.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Starting in Splunk 4.1, negative offsets are allowed and are added 
        /// to the count to compute the absolute offset (for example, offset=-1 
        /// is the last available offset). Offsets in the results are always 
        /// absolute and never negative. 
        /// </para>
        /// <para>
        /// This property's default value is "0".
        /// </para>
        /// </remarks>
        public int Offset
        {
            set { this["offset"] = value; }
        }

        /// <summary>
        /// Sets the format of the output.
        /// </summary>
        public OutputModeEnum OutputMode
        {
            set { this["output_mode"] = value.GetSplunkEnumValue(); }
        }

        /// <summary>
        /// Sets a UTC time format.
        /// </summary>
        public string OutputTimeFormat
        {
            set { this["output_time_format"] = value; }
        }

        /// <summary>
        /// Sets the post-processing search to apply to results.
        /// </summary>
        public string Search
        {
            set { this["search"] = value; }
        }

        /// <summary>
        /// Sets the type of segmentation to perform on the data, including
        /// an option to perform key/value segmentation.
        /// </summary>
        public string Segmentation
        {
            set { this["segmentation"] = value; }
        }

        /// <summary>
        /// Sets an expression to convert a formatted time string from 
        /// {start,end}_time into UTC seconds. 
        /// The default format is "%m/%d/%Y:%H:%M:%S".
        /// </summary>
        public string TimeFormat
        {
            set { this["time_format"] = value; }
        }

        /// <summary>
        /// Sets how to truncate lines to achieve the value in <see cref="MaximumLines"/>.
        /// </summary>
        public TruncationModeEnum TruncationMode
        {
            set { this["truncation_mode"] = value.GetSplunkEnumValue(); }
        }

        /* END AUTOGENERATED CODE */
    }
}
