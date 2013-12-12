﻿//-----------------------------------------------------------------------
// <copyright file="ApiClasses.cs" company="Microsoft">Copyright 2012 Microsoft Corporation</copyright>
// <auto-generated />
// <license>
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </license>

//
// DO NOT EDIT
// This class is auto generated. Edit ODataClasses.tt
//

using System;

namespace Microsoft.WindowsAzure.MediaServices.Client
{
    public partial interface IAsset
    {
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IAsset.Id"]'/>
        string Id
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IAsset.State"]'/>
        AssetState State
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IAsset.Created"]'/>
        DateTime Created
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IAsset.LastModified"]'/>
        DateTime LastModified
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IAsset.Name"]'/>
        string Name
        {
            get;
            set;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IAsset.AlternateId"]'/>
        string AlternateId
        {
            get;
            set;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IAsset.Options"]'/>
        AssetCreationOptions Options
        {
            get;
        }

        /// <include file='Documentation.xml' path='Documentation/Member[@name="IAsset.Uri"]'/>
        Uri Uri
        {
            get;
        }
    }
    public partial interface IAssetFile
    {
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IAssetFile.Id"]'/>
        string Id
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IAssetFile.MimeType"]'/>
        string MimeType
        {
            get;
            set;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IAssetFile.Created"]'/>
        DateTime Created
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IAssetFile.LastModified"]'/>
        DateTime LastModified
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IAssetFile.IsPrimary"]'/>
        bool IsPrimary
        {
            get;
            set;
        }
        
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IAssetFile.ContentFileSize"]'/>
        long ContentFileSize
        {
            get; set;
        }
        
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IAssetFile.ContentChecksum"]'/>
        [Obsolete]
        string ContentChecksum
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IAssetFile.Name"]'/>
        string Name
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IAssetFile.ParentAssetId"]'/>
        string ParentAssetId
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IAssetFile.EncryptionVersion"]'/>
        string EncryptionVersion
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IAssetFile.EncryptionScheme"]'/>
        string EncryptionScheme
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IAssetFile.IsEncrypted"]'/>
        bool IsEncrypted
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IAssetFile.EncryptionKeyId"]'/>
        string EncryptionKeyId
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IAssetFile.InitializationVector"]'/>
        string InitializationVector
        {
            get;
        }
    }
    public partial interface IContentKey
    {
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IContentKey.Id"]'/>
        string Id
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IContentKey.Created"]'/>
        DateTime Created
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IContentKey.LastModified"]'/>
        DateTime LastModified
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IContentKey.Name"]'/>
        string Name
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IContentKey.EncryptedContentKey"]'/>
        string EncryptedContentKey
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IContentKey.ContentKeyType"]'/>
        ContentKeyType ContentKeyType
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IContentKey.ProtectionKeyId"]'/>
        string ProtectionKeyId
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IContentKey.ProtectionKeyType"]'/>
        ProtectionKeyType ProtectionKeyType
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IContentKey.Checksum"]'/>
        string Checksum
        {
            get;
        }


        /// <include file='Documentation.xml' path='Documentation/Member[@name="IContentKey.AuthorizationPolicyId"]'/>
        string AuthorizationPolicyId
        {
            get; set;
    }
    }
    public partial interface IAccessPolicy
    {
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IAccessPolicy.Id"]'/>
        string Id
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IAccessPolicy.Created"]'/>
        DateTime Created
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IAccessPolicy.LastModified"]'/>
        DateTime LastModified
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IAccessPolicy.Name"]'/>
        string Name
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IAccessPolicy.Permissions"]'/>
        AccessPermissions Permissions
        {
            get;
        }
    }
    public partial interface IJobTemplate
    {
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IJobTemplate.Id"]'/>
        string Id
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IJobTemplate.Name"]'/>
        string Name
        {
            get;
            set;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IJobTemplate.TemplateType"]'/>
        JobTemplateType TemplateType
        {
            get;
            set;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IJobTemplate.Created"]'/>
        DateTime Created
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IJobTemplate.LastModified"]'/>
        DateTime LastModified
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IJobTemplate.JobTemplateBody"]'/>
        string JobTemplateBody
        {
            get;
            set;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IJobTemplate.NumberofInputAssets"]'/>
        int NumberofInputAssets
        {
            get;
            set;
        }
    }
    public partial interface ITaskTemplate
    {
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ITaskTemplate.Id"]'/>
        string Id
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ITaskTemplate.Name"]'/>
        string Name
        {
            get;
            set;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ITaskTemplate.Description"]'/>
        string Description
        {
            get;
            set;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ITaskTemplate.NumberofInputAssets"]'/>
        int NumberofInputAssets
        {
            get;
            set;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ITaskTemplate.NumberofOutputAssets"]'/>
        int NumberofOutputAssets
        {
            get;
            set;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ITaskTemplate.Configuration"]'/>
        string Configuration
        {
            get;
            set;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ITaskTemplate.MediaProcessorId"]'/>
        string MediaProcessorId
        {
            get;
            set;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ITaskTemplate.Created"]'/>
        DateTime Created
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ITaskTemplate.LastModified"]'/>
        DateTime LastModified
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ITaskTemplate.Options"]'/>
        TaskOptions Options
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ITaskTemplate.InitializationVector"]'/>
        string InitializationVector
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ITaskTemplate.EncryptionVersion"]'/>
        string EncryptionVersion
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ITaskTemplate.EncryptionScheme"]'/>
        string EncryptionScheme
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ITaskTemplate.EncryptionKeyId"]'/>
        string EncryptionKeyId
        {
            get;
        }
    }
    public partial interface IJob
    {
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IJob.Id"]'/>
        string Id
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IJob.Priority"]'/>
        int Priority
        {
            get;
            set;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IJob.State"]'/>
        JobState State
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IJob.Name"]'/>
        string Name
        {
            get;
            set;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IJob.Created"]'/>
        DateTime Created
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IJob.LastModified"]'/>
        DateTime LastModified
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IJob.StartTime"]'/>
        DateTime? StartTime
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IJob.EndTime"]'/>
        DateTime? EndTime
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IJob.RunningDuration"]'/>
        TimeSpan RunningDuration
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IJob.TemplateId"]'/>
        string TemplateId
        {
            get;
        }
    }
    public partial interface ITask
    {
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ITask.Id"]'/>
        string Id
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ITask.Name"]'/>
        string Name
        {
            get;
            set;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ITask.MediaProcessorId"]'/>
        string MediaProcessorId
        {
            get;
            set;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ITask.State"]'/>
        JobState State
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ITask.PerfMessage"]'/>
        string PerfMessage
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ITask.Priority"]'/>
        int Priority
        {
            get;
            set;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ITask.StartTime"]'/>
        DateTime? StartTime
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ITask.EndTime"]'/>
        DateTime? EndTime
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ITask.RunningDuration"]'/>
        TimeSpan RunningDuration
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ITask.TaskBody"]'/>
        string TaskBody
        {
            get;
            set;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ITask.Configuration"]'/>
        string Configuration
        {
            get;
            set;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ITask.Options"]'/>
        TaskOptions Options
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ITask.InitializationVector"]'/>
        string InitializationVector
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ITask.EncryptionVersion"]'/>
        string EncryptionVersion
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ITask.EncryptionScheme"]'/>
        string EncryptionScheme
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ITask.EncryptionKeyId"]'/>
        string EncryptionKeyId
        {
            get;
        }
    }
    public partial interface ILocator
    {
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ILocator.Id"]'/>
        string Id
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ILocator.AssetId"]'/>
        string AssetId
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ILocator.StartTime"]'/>
        DateTime? StartTime
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ILocator.ExpirationDateTime"]'/>
        DateTime ExpirationDateTime
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ILocator.AccessPolicyId"]'/>
        string AccessPolicyId
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ILocator.Type"]'/>
        LocatorType Type
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="ILocator.Path"]'/>
        string Path
        {
            get;
        }

        /// <include file='Documentation.xml' path='Documentation/Member[@name="ILocator.BaseUri"]'/>
        string BaseUri 
        { 
           get; 
        }

        /// <include file='Documentation.xml' path='Documentation/Member[@name="ILocator.ContentAccessComponent"]'/>
        string ContentAccessComponent
        {
            get;
        }

        /// <include file='Documentation.xml' path='Documentation/Member[@name="ILocator.Name"]'/>
        string Name
        {
            get; 
        }
    }
    public partial interface IMediaProcessor
    {
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IMediaProcessor.Id"]'/>
        string Id
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IMediaProcessor.Name"]'/>
        string Name
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IMediaProcessor.Version"]'/>
        string Version
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IMediaProcessor.Sku"]'/>
        string Sku
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IMediaProcessor.Vendor"]'/>
        string Vendor
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IMediaProcessor.Description"]'/>
        string Description
        {
            get;
        }
    }

    public partial interface IIngestManifest
    {
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IManifest.Created"]'/>
        DateTime Created
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IManifest.LastModified"]'/>
        DateTime LastModified
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IManifest.Id"]'/>
        string Id
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IManifest.Name"]'/>
        string Name
        {
            get;
            set;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IManifest.State"]'/>
        IngestManifestState State
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IManifest.BlobStorageUriForUpload"]'/>
        string BlobStorageUriForUpload
        {
            get;
        }

        /// <summary>
        /// Gets storage account name associated with the the <see cref="IIngestManifest"/> 
        /// </summary>
        string StorageAccountName { get; set; }
    }
    public partial interface IIngestManifestAsset
    {
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IManifestAsset.Created"]'/>
        DateTime Created
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IManifestAsset.LastModified"]'/>
        DateTime LastModified
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IManifestAsset.Id"]'/>
        string Id
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IManifestAsset.ParentIngestManifestId"]'/>
        string ParentIngestManifestId
        {
            get;
        }
    }
    public partial interface IIngestManifestFile
    {
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IManifestAssetFile.Created"]'/>
        DateTime Created
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IManifestAssetFile.LastModified"]'/>
        DateTime LastModified
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IManifestAssetFile.Id"]'/>
        string Id
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IManifestAssetFile.ParentIngestManifestId"]'/>
        string ParentIngestManifestId
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IManifestAssetFile.ParentManifestAssetId"]'/>
        string ParentIngestManifestAssetId
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IManifestAssetFile.Name"]'/>
        string Name
        {
            get;
            set;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IManifestAssetFile.State"]'/>
        IngestManifestFileState State
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IManifestAssetFile.ErrorDetail"]'/>
        string ErrorDetail
        {
            get;
            set;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IManifestAssetFile.IsPrimary"]'/>
        bool IsPrimary
        {
            get;
            set;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IManifestAssetFile.MimeType"]'/>
        string MimeType
        {
            get;
            set;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IManifestAssetFile.EncryptionVersion"]'/>
        string EncryptionVersion
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IManifestAssetFile.EncryptionScheme"]'/>
        string EncryptionScheme
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IManifestAssetFile.IsEncrypted"]'/>
        bool IsEncrypted
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IManifestAssetFile.EncryptionKeyId"]'/>
        string EncryptionKeyId
        {
            get;
        }
        /// <include file='Documentation.xml' path='Documentation/Member[@name="IManifestAssetFile.InitializationVector"]'/>
        string InitializationVector
        {
            get;
        }
    }

}
