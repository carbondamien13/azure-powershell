// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    public partial class HourlySchedule
    {
        /// <summary>
        /// Initializes a new instance of the HourlySchedule class.
        /// </summary>
        public HourlySchedule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HourlySchedule class.
        /// </summary>

        /// <param name="interval">Interval at which backup needs to be triggered. For hourly the value
        /// can be 4/6/8/12
        /// </param>

        /// <param name="scheduleWindowStartTime">To specify start time of the backup window
        /// </param>

        /// <param name="scheduleWindowDuration">To specify duration of the backup window
        /// </param>
        public HourlySchedule(int? interval = default(int?), System.DateTime? scheduleWindowStartTime = default(System.DateTime?), int? scheduleWindowDuration = default(int?))

        {
            this.Interval = interval;
            this.ScheduleWindowStartTime = scheduleWindowStartTime;
            this.ScheduleWindowDuration = scheduleWindowDuration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets interval at which backup needs to be triggered. For hourly the
        /// value
        /// can be 4/6/8/12
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "interval")]
        public int? Interval {get; set; }

        /// <summary>
        /// Gets or sets to specify start time of the backup window
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "scheduleWindowStartTime")]
        public System.DateTime? ScheduleWindowStartTime {get; set; }

        /// <summary>
        /// Gets or sets to specify duration of the backup window
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "scheduleWindowDuration")]
        public int? ScheduleWindowDuration {get; set; }
    }
}