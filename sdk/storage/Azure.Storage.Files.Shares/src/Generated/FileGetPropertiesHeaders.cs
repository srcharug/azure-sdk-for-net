// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.Storage.Files.Shares.Models;

namespace Azure.Storage.Files.Shares
{
    internal partial class FileGetPropertiesHeaders
    {
        private readonly Response _response;
        public FileGetPropertiesHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Returns the date and time the file was last modified. The date format follows RFC 1123. Any operation that modifies the file or its properties updates the last modified time. </summary>
        public DateTimeOffset? LastModified => _response.Headers.TryGetValue("Last-Modified", out DateTimeOffset? value) ? value : null;
        /// <summary> A set of name-value pairs associated with this file as user-defined metadata. </summary>
        public IDictionary<string, string> Metadata => _response.Headers.TryGetValue("x-ms-meta-", out IDictionary<string, string> value) ? value : null;
        /// <summary> Returns the type File. Reserved for future use. </summary>
        public string FileType => _response.Headers.TryGetValue("x-ms-type", out string value) ? value : null;
        /// <summary> The size of the file in bytes. This header returns the value of the &apos;x-ms-content-length&apos; header that is stored with the file. </summary>
        public long? ContentLength => _response.Headers.TryGetValue("Content-Length", out long? value) ? value : null;
        /// <summary> The content type specified for the file. The default content type is &apos;application/octet-stream&apos;. </summary>
        public string ContentType => _response.Headers.TryGetValue("Content-Type", out string value) ? value : null;
        /// <summary> If the Content-MD5 header has been set for the file, the Content-MD5 response header is returned so that the client can check for message content integrity. </summary>
        public byte[] ContentMD5 => _response.Headers.TryGetValue("Content-MD5", out byte[] value) ? value : null;
        /// <summary> If the Content-Encoding request header has previously been set for the file, the Content-Encoding value is returned in this header. </summary>
        public string ContentEncoding => _response.Headers.TryGetValue("Content-Encoding", out string value) ? value : null;
        /// <summary> If the Cache-Control request header has previously been set for the file, the Cache-Control value is returned in this header. </summary>
        public string CacheControl => _response.Headers.TryGetValue("Cache-Control", out string value) ? value : null;
        /// <summary> Returns the value that was specified for the &apos;x-ms-content-disposition&apos; header and specifies how to process the response. </summary>
        public string ContentDisposition => _response.Headers.TryGetValue("Content-Disposition", out string value) ? value : null;
        /// <summary> Returns the value that was specified for the Content-Language request header. </summary>
        public string ContentLanguage => _response.Headers.TryGetValue("Content-Language", out string value) ? value : null;
        /// <summary> Indicates the version of the File service used to execute the request. </summary>
        public string Version => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
        /// <summary> Conclusion time of the last attempted Copy File operation where this file was the destination file. This value can specify the time of a completed, aborted, or failed copy attempt. </summary>
        public DateTimeOffset? CopyCompletionTime => _response.Headers.TryGetValue("x-ms-copy-completion-time", out DateTimeOffset? value) ? value : null;
        /// <summary> Only appears when x-ms-copy-status is failed or pending. Describes cause of fatal or non-fatal copy operation failure. </summary>
        public string CopyStatusDescription => _response.Headers.TryGetValue("x-ms-copy-status-description", out string value) ? value : null;
        /// <summary> String identifier for the last attempted Copy File operation where this file was the destination file. </summary>
        public string CopyId => _response.Headers.TryGetValue("x-ms-copy-id", out string value) ? value : null;
        /// <summary> Contains the number of bytes copied and the total bytes in the source in the last attempted Copy File operation where this file was the destination file. Can show between 0 and Content-Length bytes copied. </summary>
        public string CopyProgress => _response.Headers.TryGetValue("x-ms-copy-progress", out string value) ? value : null;
        /// <summary> URL up to 2KB in length that specifies the source file used in the last attempted Copy File operation where this file was the destination file. </summary>
        public string CopySource => _response.Headers.TryGetValue("x-ms-copy-source", out string value) ? value : null;
        /// <summary> State of the copy operation identified by &apos;x-ms-copy-id&apos;. </summary>
        public CopyStatus? CopyStatus => _response.Headers.TryGetValue("x-ms-copy-status", out string value) ? value.ToCopyStatus() : null;
        /// <summary> The value of this header is set to true if the file data and application metadata are completely encrypted using the specified algorithm. Otherwise, the value is set to false (when the file is unencrypted, or if only parts of the file/application metadata are encrypted). </summary>
        public bool? IsServerEncrypted => _response.Headers.TryGetValue("x-ms-server-encrypted", out bool? value) ? value : null;
        /// <summary> Attributes set for the file. </summary>
        public string FileAttributes => _response.Headers.TryGetValue("x-ms-file-attributes", out string value) ? value : null;
        /// <summary> Creation time for the file. </summary>
        public DateTimeOffset? FileCreationTime => _response.Headers.TryGetValue("x-ms-file-creation-time", out DateTimeOffset? value) ? value : null;
        /// <summary> Last write time for the file. </summary>
        public DateTimeOffset? FileLastWriteTime => _response.Headers.TryGetValue("x-ms-file-last-write-time", out DateTimeOffset? value) ? value : null;
        /// <summary> Change time for the file. </summary>
        public DateTimeOffset? FileChangeTime => _response.Headers.TryGetValue("x-ms-file-change-time", out DateTimeOffset? value) ? value : null;
        /// <summary> Key of the permission set for the file. </summary>
        public string FilePermissionKey => _response.Headers.TryGetValue("x-ms-file-permission-key", out string value) ? value : null;
        /// <summary> The fileId of the file. </summary>
        public string FileId => _response.Headers.TryGetValue("x-ms-file-id", out string value) ? value : null;
        /// <summary> The parent fileId of the file. </summary>
        public string FileParentId => _response.Headers.TryGetValue("x-ms-file-parent-id", out string value) ? value : null;
        /// <summary> When a file is leased, specifies whether the lease is of infinite or fixed duration. </summary>
        public ShareLeaseDuration? LeaseDuration => _response.Headers.TryGetValue("x-ms-lease-duration", out string value) ? value.ToShareLeaseDuration() : null;
        /// <summary> Lease state of the file. </summary>
        public ShareLeaseState? LeaseState => _response.Headers.TryGetValue("x-ms-lease-state", out string value) ? value.ToShareLeaseState() : null;
        /// <summary> The current lease status of the file. </summary>
        public ShareLeaseStatus? LeaseStatus => _response.Headers.TryGetValue("x-ms-lease-status", out string value) ? value.ToShareLeaseStatus() : null;
    }
}
