/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.CoreService.Models
{
    /// <summary>
    /// Defines the backup frequency and retention period for a volume backup policy. For more information,
    /// see [Policy-Based Backups](https://docs.cloud.oracle.com/iaas/Content/Block/Tasks/schedulingvolumebackups.htm).
    /// 
    /// </summary>
    public class VolumeBackupSchedule 
    {
                ///
        /// <value>
        /// The type of volume backup to create.
        /// </value>
        ///
        public enum BackupTypeEnum {
            [EnumMember(Value = "FULL")]
            Full,
            [EnumMember(Value = "INCREMENTAL")]
            Incremental
        };

        /// <value>
        /// The type of volume backup to create.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BackupType is required.")]
        [JsonProperty(PropertyName = "backupType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<BackupTypeEnum> BackupType { get; set; }
        
        /// <value>
        /// The number of seconds that the volume backup start time should be shifted from the default interval boundaries specified by the period. The volume backup start time is the frequency start time plus the offset.
        /// </value>
        [JsonProperty(PropertyName = "offsetSeconds")]
        public System.Nullable<int> OffsetSeconds { get; set; }
                ///
        /// <value>
        /// The volume backup frequency.
        /// </value>
        ///
        public enum PeriodEnum {
            [EnumMember(Value = "ONE_HOUR")]
            OneHour,
            [EnumMember(Value = "ONE_DAY")]
            OneDay,
            [EnumMember(Value = "ONE_WEEK")]
            OneWeek,
            [EnumMember(Value = "ONE_MONTH")]
            OneMonth,
            [EnumMember(Value = "ONE_YEAR")]
            OneYear
        };

        /// <value>
        /// The volume backup frequency.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Period is required.")]
        [JsonProperty(PropertyName = "period")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PeriodEnum> Period { get; set; }
                ///
        /// <value>
        /// Indicates how the offset is defined. If value is `STRUCTURED`, then `hourOfDay`, `dayOfWeek`, `dayOfMonth`, and `month` fields are used and `offsetSeconds` will be ignored in requests and users should ignore its value from the responses.
        /// <br/>
        /// `hourOfDay` is applicable for periods `ONE_DAY`, `ONE_WEEK`, `ONE_MONTH` and `ONE_YEAR`.
        /// <br/>
        /// `dayOfWeek` is applicable for period `ONE_WEEK`.
        /// <br/>
        /// `dayOfMonth` is applicable for periods `ONE_MONTH` and `ONE_YEAR`.
        /// <br/>
        /// 'month' is applicable for period 'ONE_YEAR'.
        /// <br/>
        /// They will be ignored in the requests for inapplicable periods.
        /// <br/>
        /// If value is `NUMERIC_SECONDS`, then `offsetSeconds` will be used for both requests and responses and the structured fields will be ignored in the requests and users should ignore their values from the responses.
        /// <br/>
        /// For clients using older versions of Apis and not sending `offsetType` in their requests, the behaviour is just like `NUMERIC_SECONDS`.
        /// </value>
        ///
        public enum OffsetTypeEnum {
            [EnumMember(Value = "STRUCTURED")]
            Structured,
            [EnumMember(Value = "NUMERIC_SECONDS")]
            NumericSeconds
        };

        /// <value>
        /// Indicates how the offset is defined. If value is `STRUCTURED`, then `hourOfDay`, `dayOfWeek`, `dayOfMonth`, and `month` fields are used and `offsetSeconds` will be ignored in requests and users should ignore its value from the responses.
        /// <br/>
        /// `hourOfDay` is applicable for periods `ONE_DAY`, `ONE_WEEK`, `ONE_MONTH` and `ONE_YEAR`.
        /// <br/>
        /// `dayOfWeek` is applicable for period `ONE_WEEK`.
        /// <br/>
        /// `dayOfMonth` is applicable for periods `ONE_MONTH` and `ONE_YEAR`.
        /// <br/>
        /// 'month' is applicable for period 'ONE_YEAR'.
        /// <br/>
        /// They will be ignored in the requests for inapplicable periods.
        /// <br/>
        /// If value is `NUMERIC_SECONDS`, then `offsetSeconds` will be used for both requests and responses and the structured fields will be ignored in the requests and users should ignore their values from the responses.
        /// <br/>
        /// For clients using older versions of Apis and not sending `offsetType` in their requests, the behaviour is just like `NUMERIC_SECONDS`.
        /// </value>
        [JsonProperty(PropertyName = "offsetType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OffsetTypeEnum> OffsetType { get; set; }
        
        /// <value>
        /// The hour of the day to schedule the volume backup.
        /// </value>
        [JsonProperty(PropertyName = "hourOfDay")]
        public System.Nullable<int> HourOfDay { get; set; }
                ///
        /// <value>
        /// The day of the week to schedule the volume backup.
        /// </value>
        ///
        public enum DayOfWeekEnum {
            [EnumMember(Value = "MONDAY")]
            Monday,
            [EnumMember(Value = "TUESDAY")]
            Tuesday,
            [EnumMember(Value = "WEDNESDAY")]
            Wednesday,
            [EnumMember(Value = "THURSDAY")]
            Thursday,
            [EnumMember(Value = "FRIDAY")]
            Friday,
            [EnumMember(Value = "SATURDAY")]
            Saturday,
            [EnumMember(Value = "SUNDAY")]
            Sunday
        };

        /// <value>
        /// The day of the week to schedule the volume backup.
        /// </value>
        [JsonProperty(PropertyName = "dayOfWeek")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DayOfWeekEnum> DayOfWeek { get; set; }
        
        /// <value>
        /// The day of the month to schedule the volume backup.
        /// </value>
        [JsonProperty(PropertyName = "dayOfMonth")]
        public System.Nullable<int> DayOfMonth { get; set; }
                ///
        /// <value>
        /// The month of the year to schedule the volume backup.
        /// </value>
        ///
        public enum MonthEnum {
            [EnumMember(Value = "JANUARY")]
            January,
            [EnumMember(Value = "FEBRUARY")]
            February,
            [EnumMember(Value = "MARCH")]
            March,
            [EnumMember(Value = "APRIL")]
            April,
            [EnumMember(Value = "MAY")]
            May,
            [EnumMember(Value = "JUNE")]
            June,
            [EnumMember(Value = "JULY")]
            July,
            [EnumMember(Value = "AUGUST")]
            August,
            [EnumMember(Value = "SEPTEMBER")]
            September,
            [EnumMember(Value = "OCTOBER")]
            October,
            [EnumMember(Value = "NOVEMBER")]
            November,
            [EnumMember(Value = "DECEMBER")]
            December
        };

        /// <value>
        /// The month of the year to schedule the volume backup.
        /// </value>
        [JsonProperty(PropertyName = "month")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MonthEnum> Month { get; set; }
        
        /// <value>
        /// How long, in seconds, to keep the volume backups created by this schedule.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RetentionSeconds is required.")]
        [JsonProperty(PropertyName = "retentionSeconds")]
        public System.Nullable<int> RetentionSeconds { get; set; }
                ///
        /// <value>
        /// Specifies what time zone is the schedule in
        /// </value>
        ///
        public enum TimeZoneEnum {
            [EnumMember(Value = "UTC")]
            Utc,
            [EnumMember(Value = "REGIONAL_DATA_CENTER_TIME")]
            RegionalDataCenterTime
        };

        /// <value>
        /// Specifies what time zone is the schedule in
        /// </value>
        [JsonProperty(PropertyName = "timeZone")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TimeZoneEnum> TimeZone { get; set; }
        
    }
}
