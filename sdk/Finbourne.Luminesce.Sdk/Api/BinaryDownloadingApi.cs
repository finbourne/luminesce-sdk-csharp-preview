/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.14.692
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Finbourne.Luminesce.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBinaryDownloadingApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [EXPERIMENTAL] DownloadBinary: Downloads the latest version (or specific if needs be) of the specified Luminesce Binary, given the required entitlements.
        /// </summary>
        /// <remarks>
        ///  Downloads the latest version (or specific if needs be) of the specified Luminesce Binary, given the required entitlements.  *NOTE:* This endpoint is an alternative to time-consuming manual distribution via Drive or Email. &gt; it relies on as underlying datastore that is not quite as \&quot;Highly Available\&quot; to the degree  &gt; that FINBOURNE services generally are.   &gt; Thus it is not subject to the same SLAs as other API endpoints are. &gt; *If you perceive an outage, please try again later.*  Once a file has been downloaded the following steps can be used to install it (for the dotnet tools at least):  1. Open a terminal and cd to the directory you downloaded it to 2. Install / extract files from that package via: &#x60;&#x60;&#x60; dotnet tool install NameOfFileWithoutVersionNumberOrExtension -g - -add-source \&quot;.\&quot; &#x60;&#x60;&#x60; e.g. &#x60;&#x60;&#x60; dotnet tool install Finbourne.Luminesce.DbProviders.Oracle_Snowflake -g - -add-source \&quot;.\&quot; &#x60;&#x60;&#x60; 3. Execute them (see documentation for specific binary)...  The installed binaries can then be found in - Windows - &#x60;%USERPROFILE%\\.dotnet\\tools\\.store\\&#x60; - Linux/macOS - &#x60;$HOME/.dotnet/tools/.store/&#x60;  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - binary file is not available for some reason (e.g. permissions or invalid version) - 401 Unauthorized 
        /// </remarks>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Type of binary to download (each requires separate licenses and entitlements) (optional)</param>
        /// <param name="version">An explicit version of the binary.  Leave blank to get the latest version (recommended) (optional)</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream DownloadBinary(LuminesceBinaryType? type = default(LuminesceBinaryType?), string version = default(string));

        /// <summary>
        /// [EXPERIMENTAL] DownloadBinary: Downloads the latest version (or specific if needs be) of the specified Luminesce Binary, given the required entitlements.
        /// </summary>
        /// <remarks>
        ///  Downloads the latest version (or specific if needs be) of the specified Luminesce Binary, given the required entitlements.  *NOTE:* This endpoint is an alternative to time-consuming manual distribution via Drive or Email. &gt; it relies on as underlying datastore that is not quite as \&quot;Highly Available\&quot; to the degree  &gt; that FINBOURNE services generally are.   &gt; Thus it is not subject to the same SLAs as other API endpoints are. &gt; *If you perceive an outage, please try again later.*  Once a file has been downloaded the following steps can be used to install it (for the dotnet tools at least):  1. Open a terminal and cd to the directory you downloaded it to 2. Install / extract files from that package via: &#x60;&#x60;&#x60; dotnet tool install NameOfFileWithoutVersionNumberOrExtension -g - -add-source \&quot;.\&quot; &#x60;&#x60;&#x60; e.g. &#x60;&#x60;&#x60; dotnet tool install Finbourne.Luminesce.DbProviders.Oracle_Snowflake -g - -add-source \&quot;.\&quot; &#x60;&#x60;&#x60; 3. Execute them (see documentation for specific binary)...  The installed binaries can then be found in - Windows - &#x60;%USERPROFILE%\\.dotnet\\tools\\.store\\&#x60; - Linux/macOS - &#x60;$HOME/.dotnet/tools/.store/&#x60;  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - binary file is not available for some reason (e.g. permissions or invalid version) - 401 Unauthorized 
        /// </remarks>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Type of binary to download (each requires separate licenses and entitlements) (optional)</param>
        /// <param name="version">An explicit version of the binary.  Leave blank to get the latest version (recommended) (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> DownloadBinaryWithHttpInfo(LuminesceBinaryType? type = default(LuminesceBinaryType?), string version = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBinaryDownloadingApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// [EXPERIMENTAL] DownloadBinary: Downloads the latest version (or specific if needs be) of the specified Luminesce Binary, given the required entitlements.
        /// </summary>
        /// <remarks>
        ///  Downloads the latest version (or specific if needs be) of the specified Luminesce Binary, given the required entitlements.  *NOTE:* This endpoint is an alternative to time-consuming manual distribution via Drive or Email. &gt; it relies on as underlying datastore that is not quite as \&quot;Highly Available\&quot; to the degree  &gt; that FINBOURNE services generally are.   &gt; Thus it is not subject to the same SLAs as other API endpoints are. &gt; *If you perceive an outage, please try again later.*  Once a file has been downloaded the following steps can be used to install it (for the dotnet tools at least):  1. Open a terminal and cd to the directory you downloaded it to 2. Install / extract files from that package via: &#x60;&#x60;&#x60; dotnet tool install NameOfFileWithoutVersionNumberOrExtension -g - -add-source \&quot;.\&quot; &#x60;&#x60;&#x60; e.g. &#x60;&#x60;&#x60; dotnet tool install Finbourne.Luminesce.DbProviders.Oracle_Snowflake -g - -add-source \&quot;.\&quot; &#x60;&#x60;&#x60; 3. Execute them (see documentation for specific binary)...  The installed binaries can then be found in - Windows - &#x60;%USERPROFILE%\\.dotnet\\tools\\.store\\&#x60; - Linux/macOS - &#x60;$HOME/.dotnet/tools/.store/&#x60;  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - binary file is not available for some reason (e.g. permissions or invalid version) - 401 Unauthorized 
        /// </remarks>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Type of binary to download (each requires separate licenses and entitlements) (optional)</param>
        /// <param name="version">An explicit version of the binary.  Leave blank to get the latest version (recommended) (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> DownloadBinaryAsync(LuminesceBinaryType? type = default(LuminesceBinaryType?), string version = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EXPERIMENTAL] DownloadBinary: Downloads the latest version (or specific if needs be) of the specified Luminesce Binary, given the required entitlements.
        /// </summary>
        /// <remarks>
        ///  Downloads the latest version (or specific if needs be) of the specified Luminesce Binary, given the required entitlements.  *NOTE:* This endpoint is an alternative to time-consuming manual distribution via Drive or Email. &gt; it relies on as underlying datastore that is not quite as \&quot;Highly Available\&quot; to the degree  &gt; that FINBOURNE services generally are.   &gt; Thus it is not subject to the same SLAs as other API endpoints are. &gt; *If you perceive an outage, please try again later.*  Once a file has been downloaded the following steps can be used to install it (for the dotnet tools at least):  1. Open a terminal and cd to the directory you downloaded it to 2. Install / extract files from that package via: &#x60;&#x60;&#x60; dotnet tool install NameOfFileWithoutVersionNumberOrExtension -g - -add-source \&quot;.\&quot; &#x60;&#x60;&#x60; e.g. &#x60;&#x60;&#x60; dotnet tool install Finbourne.Luminesce.DbProviders.Oracle_Snowflake -g - -add-source \&quot;.\&quot; &#x60;&#x60;&#x60; 3. Execute them (see documentation for specific binary)...  The installed binaries can then be found in - Windows - &#x60;%USERPROFILE%\\.dotnet\\tools\\.store\\&#x60; - Linux/macOS - &#x60;$HOME/.dotnet/tools/.store/&#x60;  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - binary file is not available for some reason (e.g. permissions or invalid version) - 401 Unauthorized 
        /// </remarks>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Type of binary to download (each requires separate licenses and entitlements) (optional)</param>
        /// <param name="version">An explicit version of the binary.  Leave blank to get the latest version (recommended) (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> DownloadBinaryWithHttpInfoAsync(LuminesceBinaryType? type = default(LuminesceBinaryType?), string version = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBinaryDownloadingApi : IBinaryDownloadingApiSync, IBinaryDownloadingApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BinaryDownloadingApi : IBinaryDownloadingApi
    {
        private Finbourne.Luminesce.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryDownloadingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BinaryDownloadingApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryDownloadingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BinaryDownloadingApi(String basePath)
        {
            this.Configuration = Finbourne.Luminesce.Sdk.Client.Configuration.MergeConfigurations(
                Finbourne.Luminesce.Sdk.Client.GlobalConfiguration.Instance,
                new Finbourne.Luminesce.Sdk.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Finbourne.Luminesce.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Finbourne.Luminesce.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Finbourne.Luminesce.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryDownloadingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BinaryDownloadingApi(Finbourne.Luminesce.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = configuration;
            this.Client = new Finbourne.Luminesce.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Finbourne.Luminesce.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Finbourne.Luminesce.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryDownloadingApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public BinaryDownloadingApi(Finbourne.Luminesce.Sdk.Client.ISynchronousClient client, Finbourne.Luminesce.Sdk.Client.IAsynchronousClient asyncClient, Finbourne.Luminesce.Sdk.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Finbourne.Luminesce.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Finbourne.Luminesce.Sdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Finbourne.Luminesce.Sdk.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Finbourne.Luminesce.Sdk.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Finbourne.Luminesce.Sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// [EXPERIMENTAL] DownloadBinary: Downloads the latest version (or specific if needs be) of the specified Luminesce Binary, given the required entitlements.  Downloads the latest version (or specific if needs be) of the specified Luminesce Binary, given the required entitlements.  *NOTE:* This endpoint is an alternative to time-consuming manual distribution via Drive or Email. &gt; it relies on as underlying datastore that is not quite as \&quot;Highly Available\&quot; to the degree  &gt; that FINBOURNE services generally are.   &gt; Thus it is not subject to the same SLAs as other API endpoints are. &gt; *If you perceive an outage, please try again later.*  Once a file has been downloaded the following steps can be used to install it (for the dotnet tools at least):  1. Open a terminal and cd to the directory you downloaded it to 2. Install / extract files from that package via: &#x60;&#x60;&#x60; dotnet tool install NameOfFileWithoutVersionNumberOrExtension -g - -add-source \&quot;.\&quot; &#x60;&#x60;&#x60; e.g. &#x60;&#x60;&#x60; dotnet tool install Finbourne.Luminesce.DbProviders.Oracle_Snowflake -g - -add-source \&quot;.\&quot; &#x60;&#x60;&#x60; 3. Execute them (see documentation for specific binary)...  The installed binaries can then be found in - Windows - &#x60;%USERPROFILE%\\.dotnet\\tools\\.store\\&#x60; - Linux/macOS - &#x60;$HOME/.dotnet/tools/.store/&#x60;  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - binary file is not available for some reason (e.g. permissions or invalid version) - 401 Unauthorized 
        /// </summary>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Type of binary to download (each requires separate licenses and entitlements) (optional)</param>
        /// <param name="version">An explicit version of the binary.  Leave blank to get the latest version (recommended) (optional)</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream DownloadBinary(LuminesceBinaryType? type = default(LuminesceBinaryType?), string version = default(string))
        {
            Finbourne.Luminesce.Sdk.Client.ApiResponse<System.IO.Stream> localVarResponse = DownloadBinaryWithHttpInfo(type, version);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EXPERIMENTAL] DownloadBinary: Downloads the latest version (or specific if needs be) of the specified Luminesce Binary, given the required entitlements.  Downloads the latest version (or specific if needs be) of the specified Luminesce Binary, given the required entitlements.  *NOTE:* This endpoint is an alternative to time-consuming manual distribution via Drive or Email. &gt; it relies on as underlying datastore that is not quite as \&quot;Highly Available\&quot; to the degree  &gt; that FINBOURNE services generally are.   &gt; Thus it is not subject to the same SLAs as other API endpoints are. &gt; *If you perceive an outage, please try again later.*  Once a file has been downloaded the following steps can be used to install it (for the dotnet tools at least):  1. Open a terminal and cd to the directory you downloaded it to 2. Install / extract files from that package via: &#x60;&#x60;&#x60; dotnet tool install NameOfFileWithoutVersionNumberOrExtension -g - -add-source \&quot;.\&quot; &#x60;&#x60;&#x60; e.g. &#x60;&#x60;&#x60; dotnet tool install Finbourne.Luminesce.DbProviders.Oracle_Snowflake -g - -add-source \&quot;.\&quot; &#x60;&#x60;&#x60; 3. Execute them (see documentation for specific binary)...  The installed binaries can then be found in - Windows - &#x60;%USERPROFILE%\\.dotnet\\tools\\.store\\&#x60; - Linux/macOS - &#x60;$HOME/.dotnet/tools/.store/&#x60;  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - binary file is not available for some reason (e.g. permissions or invalid version) - 401 Unauthorized 
        /// </summary>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Type of binary to download (each requires separate licenses and entitlements) (optional)</param>
        /// <param name="version">An explicit version of the binary.  Leave blank to get the latest version (recommended) (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public Finbourne.Luminesce.Sdk.Client.ApiResponse<System.IO.Stream> DownloadBinaryWithHttpInfo(LuminesceBinaryType? type = default(LuminesceBinaryType?), string version = default(string))
        {
            Finbourne.Luminesce.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Luminesce.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/octet-stream",
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Finbourne.Luminesce.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Finbourne.Luminesce.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (type != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Luminesce.Sdk.Client.ClientUtils.ParameterToMultiMap("", "type", type));
            }
            if (version != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Luminesce.Sdk.Client.ClientUtils.ParameterToMultiMap("", "version", version));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.14.692");

            // make the HTTP request
            var localVarResponse = this.Client.Get<System.IO.Stream>("/api/Download/download", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DownloadBinary", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EXPERIMENTAL] DownloadBinary: Downloads the latest version (or specific if needs be) of the specified Luminesce Binary, given the required entitlements.  Downloads the latest version (or specific if needs be) of the specified Luminesce Binary, given the required entitlements.  *NOTE:* This endpoint is an alternative to time-consuming manual distribution via Drive or Email. &gt; it relies on as underlying datastore that is not quite as \&quot;Highly Available\&quot; to the degree  &gt; that FINBOURNE services generally are.   &gt; Thus it is not subject to the same SLAs as other API endpoints are. &gt; *If you perceive an outage, please try again later.*  Once a file has been downloaded the following steps can be used to install it (for the dotnet tools at least):  1. Open a terminal and cd to the directory you downloaded it to 2. Install / extract files from that package via: &#x60;&#x60;&#x60; dotnet tool install NameOfFileWithoutVersionNumberOrExtension -g - -add-source \&quot;.\&quot; &#x60;&#x60;&#x60; e.g. &#x60;&#x60;&#x60; dotnet tool install Finbourne.Luminesce.DbProviders.Oracle_Snowflake -g - -add-source \&quot;.\&quot; &#x60;&#x60;&#x60; 3. Execute them (see documentation for specific binary)...  The installed binaries can then be found in - Windows - &#x60;%USERPROFILE%\\.dotnet\\tools\\.store\\&#x60; - Linux/macOS - &#x60;$HOME/.dotnet/tools/.store/&#x60;  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - binary file is not available for some reason (e.g. permissions or invalid version) - 401 Unauthorized 
        /// </summary>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Type of binary to download (each requires separate licenses and entitlements) (optional)</param>
        /// <param name="version">An explicit version of the binary.  Leave blank to get the latest version (recommended) (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> DownloadBinaryAsync(LuminesceBinaryType? type = default(LuminesceBinaryType?), string version = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Finbourne.Luminesce.Sdk.Client.ApiResponse<System.IO.Stream> localVarResponse = await DownloadBinaryWithHttpInfoAsync(type, version, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EXPERIMENTAL] DownloadBinary: Downloads the latest version (or specific if needs be) of the specified Luminesce Binary, given the required entitlements.  Downloads the latest version (or specific if needs be) of the specified Luminesce Binary, given the required entitlements.  *NOTE:* This endpoint is an alternative to time-consuming manual distribution via Drive or Email. &gt; it relies on as underlying datastore that is not quite as \&quot;Highly Available\&quot; to the degree  &gt; that FINBOURNE services generally are.   &gt; Thus it is not subject to the same SLAs as other API endpoints are. &gt; *If you perceive an outage, please try again later.*  Once a file has been downloaded the following steps can be used to install it (for the dotnet tools at least):  1. Open a terminal and cd to the directory you downloaded it to 2. Install / extract files from that package via: &#x60;&#x60;&#x60; dotnet tool install NameOfFileWithoutVersionNumberOrExtension -g - -add-source \&quot;.\&quot; &#x60;&#x60;&#x60; e.g. &#x60;&#x60;&#x60; dotnet tool install Finbourne.Luminesce.DbProviders.Oracle_Snowflake -g - -add-source \&quot;.\&quot; &#x60;&#x60;&#x60; 3. Execute them (see documentation for specific binary)...  The installed binaries can then be found in - Windows - &#x60;%USERPROFILE%\\.dotnet\\tools\\.store\\&#x60; - Linux/macOS - &#x60;$HOME/.dotnet/tools/.store/&#x60;  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - binary file is not available for some reason (e.g. permissions or invalid version) - 401 Unauthorized 
        /// </summary>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Type of binary to download (each requires separate licenses and entitlements) (optional)</param>
        /// <param name="version">An explicit version of the binary.  Leave blank to get the latest version (recommended) (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<Finbourne.Luminesce.Sdk.Client.ApiResponse<System.IO.Stream>> DownloadBinaryWithHttpInfoAsync(LuminesceBinaryType? type = default(LuminesceBinaryType?), string version = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Finbourne.Luminesce.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Luminesce.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/octet-stream",
                "text/plain",
                "application/json",
                "text/json"
            };


            var localVarContentType = Finbourne.Luminesce.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Finbourne.Luminesce.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (type != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Luminesce.Sdk.Client.ClientUtils.ParameterToMultiMap("", "type", type));
            }
            if (version != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Luminesce.Sdk.Client.ClientUtils.ParameterToMultiMap("", "version", version));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.14.692");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<System.IO.Stream>("/api/Download/download", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DownloadBinary", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}