// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using System.Linq;

    /// <summary>
    /// A long term retention backup.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class LongTermRetentionBackup : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the LongTermRetentionBackup class.
        /// </summary>
        public LongTermRetentionBackup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LongTermRetentionBackup class.
        /// </summary>

        /// <param name="id">Resource ID.
        /// </param>

        /// <param name="name">Resource name.
        /// </param>

        /// <param name="type">Resource type.
        /// </param>

        /// <param name="serverName">The server name that the backup database belong to.
        /// </param>

        /// <param name="serverCreateTime">The create time of the server.
        /// </param>

        /// <param name="databaseName">The name of the database the backup belong to
        /// </param>

        /// <param name="databaseDeletionTime">The delete time of the database
        /// </param>

        /// <param name="backupTime">The time the backup was taken
        /// </param>

        /// <param name="backupExpirationTime">The time the long term retention backup will expire.
        /// </param>

        /// <param name="backupStorageRedundancy">The storage redundancy type of the backup
        /// Possible values include: 'Geo', 'Local', 'Zone', 'GeoZone'</param>

        /// <param name="requestedBackupStorageRedundancy">The storage redundancy type of the backup
        /// Possible values include: 'Geo', 'Local', 'Zone', 'GeoZone'</param>
        public LongTermRetentionBackup(string id = default(string), string name = default(string), string type = default(string), string serverName = default(string), System.DateTime? serverCreateTime = default(System.DateTime?), string databaseName = default(string), System.DateTime? databaseDeletionTime = default(System.DateTime?), System.DateTime? backupTime = default(System.DateTime?), System.DateTime? backupExpirationTime = default(System.DateTime?), string backupStorageRedundancy = default(string), string requestedBackupStorageRedundancy = default(string))

        : base(id, name, type)
        {
            this.ServerName = serverName;
            this.ServerCreateTime = serverCreateTime;
            this.DatabaseName = databaseName;
            this.DatabaseDeletionTime = databaseDeletionTime;
            this.BackupTime = backupTime;
            this.BackupExpirationTime = backupExpirationTime;
            this.BackupStorageRedundancy = backupStorageRedundancy;
            this.RequestedBackupStorageRedundancy = requestedBackupStorageRedundancy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the server name that the backup database belong to.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.serverName")]
        public string ServerName {get; private set; }

        /// <summary>
        /// Gets the create time of the server.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.serverCreateTime")]
        public System.DateTime? ServerCreateTime {get; private set; }

        /// <summary>
        /// Gets the name of the database the backup belong to
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.databaseName")]
        public string DatabaseName {get; private set; }

        /// <summary>
        /// Gets the delete time of the database
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.databaseDeletionTime")]
        public System.DateTime? DatabaseDeletionTime {get; private set; }

        /// <summary>
        /// Gets the time the backup was taken
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.backupTime")]
        public System.DateTime? BackupTime {get; private set; }

        /// <summary>
        /// Gets the time the long term retention backup will expire.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.backupExpirationTime")]
        public System.DateTime? BackupExpirationTime {get; private set; }

        /// <summary>
        /// Gets the storage redundancy type of the backup Possible values include: &#39;Geo&#39;, &#39;Local&#39;, &#39;Zone&#39;, &#39;GeoZone&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.backupStorageRedundancy")]
        public string BackupStorageRedundancy {get; private set; }

        /// <summary>
        /// Gets or sets the storage redundancy type of the backup Possible values include: &#39;Geo&#39;, &#39;Local&#39;, &#39;Zone&#39;, &#39;GeoZone&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.requestedBackupStorageRedundancy")]
        public string RequestedBackupStorageRedundancy {get; set; }
    }
}