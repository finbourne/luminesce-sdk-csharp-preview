/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.14.136
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
    public interface ILuminesceCertificateManagementApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [EXPERIMENTAL] GetCertificates: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format)
        /// </summary>
        /// <remarks>
        ///  Lists all the certificates previously minted to which you have access.  The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized 
        /// </remarks>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ICollection&lt;CertificateState&gt;</returns>
        ICollection<CertificateState> GetCertificates();

        /// <summary>
        /// [EXPERIMENTAL] GetCertificates: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format)
        /// </summary>
        /// <remarks>
        ///  Lists all the certificates previously minted to which you have access.  The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized 
        /// </remarks>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ICollection&lt;CertificateState&gt;</returns>
        ApiResponse<ICollection<CertificateState>> GetCertificatesWithHttpInfo();
        /// <summary>
        /// [EXPERIMENTAL] ManageCertificate: Manages a new certificate (Create / Renew / Revoke)
        /// </summary>
        /// <remarks>
        ///  Manages a certificate.  This could be creating a new one, renewing an old one or revoking one explicitly.  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something about the request cannot be processed - 401 Unauthorized 
        /// </remarks>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="action">The Action to perform, e.g. Create / Renew / Revoke (optional)</param>
        /// <param name="type">User or Domain level cert (Domain level requires additional entitlements) (optional)</param>
        /// <param name="version">Version number of the cert, the request will fail to validate if incorrect (optional, default to 1)</param>
        /// <param name="validityStart">When should the cert first be valid (defaults to the current time in UTC) (optional)</param>
        /// <param name="validityEnd">When should the cert no longer be valid (defaults to 13 months from now) (optional)</param>
        /// <param name="dryRun">True will just validate the request, but perform no changes to any system (optional, default to true)</param>
        /// <returns>CertificateState</returns>
        CertificateState ManageCertificate(CertificateAction? action = default(CertificateAction?), CertificateType? type = default(CertificateType?), int? version = default(int?), DateTimeOffset? validityStart = default(DateTimeOffset?), DateTimeOffset? validityEnd = default(DateTimeOffset?), bool? dryRun = default(bool?));

        /// <summary>
        /// [EXPERIMENTAL] ManageCertificate: Manages a new certificate (Create / Renew / Revoke)
        /// </summary>
        /// <remarks>
        ///  Manages a certificate.  This could be creating a new one, renewing an old one or revoking one explicitly.  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something about the request cannot be processed - 401 Unauthorized 
        /// </remarks>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="action">The Action to perform, e.g. Create / Renew / Revoke (optional)</param>
        /// <param name="type">User or Domain level cert (Domain level requires additional entitlements) (optional)</param>
        /// <param name="version">Version number of the cert, the request will fail to validate if incorrect (optional, default to 1)</param>
        /// <param name="validityStart">When should the cert first be valid (defaults to the current time in UTC) (optional)</param>
        /// <param name="validityEnd">When should the cert no longer be valid (defaults to 13 months from now) (optional)</param>
        /// <param name="dryRun">True will just validate the request, but perform no changes to any system (optional, default to true)</param>
        /// <returns>ApiResponse of CertificateState</returns>
        ApiResponse<CertificateState> ManageCertificateWithHttpInfo(CertificateAction? action = default(CertificateAction?), CertificateType? type = default(CertificateType?), int? version = default(int?), DateTimeOffset? validityStart = default(DateTimeOffset?), DateTimeOffset? validityEnd = default(DateTimeOffset?), bool? dryRun = default(bool?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILuminesceCertificateManagementApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// [EXPERIMENTAL] GetCertificates: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format)
        /// </summary>
        /// <remarks>
        ///  Lists all the certificates previously minted to which you have access.  The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized 
        /// </remarks>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ICollection&lt;CertificateState&gt;</returns>
        System.Threading.Tasks.Task<ICollection<CertificateState>> GetCertificatesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EXPERIMENTAL] GetCertificates: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format)
        /// </summary>
        /// <remarks>
        ///  Lists all the certificates previously minted to which you have access.  The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized 
        /// </remarks>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ICollection&lt;CertificateState&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<ICollection<CertificateState>>> GetCertificatesWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EXPERIMENTAL] ManageCertificate: Manages a new certificate (Create / Renew / Revoke)
        /// </summary>
        /// <remarks>
        ///  Manages a certificate.  This could be creating a new one, renewing an old one or revoking one explicitly.  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something about the request cannot be processed - 401 Unauthorized 
        /// </remarks>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="action">The Action to perform, e.g. Create / Renew / Revoke (optional)</param>
        /// <param name="type">User or Domain level cert (Domain level requires additional entitlements) (optional)</param>
        /// <param name="version">Version number of the cert, the request will fail to validate if incorrect (optional, default to 1)</param>
        /// <param name="validityStart">When should the cert first be valid (defaults to the current time in UTC) (optional)</param>
        /// <param name="validityEnd">When should the cert no longer be valid (defaults to 13 months from now) (optional)</param>
        /// <param name="dryRun">True will just validate the request, but perform no changes to any system (optional, default to true)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CertificateState</returns>
        System.Threading.Tasks.Task<CertificateState> ManageCertificateAsync(CertificateAction? action = default(CertificateAction?), CertificateType? type = default(CertificateType?), int? version = default(int?), DateTimeOffset? validityStart = default(DateTimeOffset?), DateTimeOffset? validityEnd = default(DateTimeOffset?), bool? dryRun = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EXPERIMENTAL] ManageCertificate: Manages a new certificate (Create / Renew / Revoke)
        /// </summary>
        /// <remarks>
        ///  Manages a certificate.  This could be creating a new one, renewing an old one or revoking one explicitly.  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something about the request cannot be processed - 401 Unauthorized 
        /// </remarks>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="action">The Action to perform, e.g. Create / Renew / Revoke (optional)</param>
        /// <param name="type">User or Domain level cert (Domain level requires additional entitlements) (optional)</param>
        /// <param name="version">Version number of the cert, the request will fail to validate if incorrect (optional, default to 1)</param>
        /// <param name="validityStart">When should the cert first be valid (defaults to the current time in UTC) (optional)</param>
        /// <param name="validityEnd">When should the cert no longer be valid (defaults to 13 months from now) (optional)</param>
        /// <param name="dryRun">True will just validate the request, but perform no changes to any system (optional, default to true)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CertificateState)</returns>
        System.Threading.Tasks.Task<ApiResponse<CertificateState>> ManageCertificateWithHttpInfoAsync(CertificateAction? action = default(CertificateAction?), CertificateType? type = default(CertificateType?), int? version = default(int?), DateTimeOffset? validityStart = default(DateTimeOffset?), DateTimeOffset? validityEnd = default(DateTimeOffset?), bool? dryRun = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILuminesceCertificateManagementApi : ILuminesceCertificateManagementApiSync, ILuminesceCertificateManagementApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LuminesceCertificateManagementApi : ILuminesceCertificateManagementApi
    {
        private Finbourne.Luminesce.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LuminesceCertificateManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LuminesceCertificateManagementApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LuminesceCertificateManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LuminesceCertificateManagementApi(String basePath)
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
        /// Initializes a new instance of the <see cref="LuminesceCertificateManagementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LuminesceCertificateManagementApi(Finbourne.Luminesce.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = configuration;
            this.Client = new Finbourne.Luminesce.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Finbourne.Luminesce.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Finbourne.Luminesce.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LuminesceCertificateManagementApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public LuminesceCertificateManagementApi(Finbourne.Luminesce.Sdk.Client.ISynchronousClient client, Finbourne.Luminesce.Sdk.Client.IAsynchronousClient asyncClient, Finbourne.Luminesce.Sdk.Client.IReadableConfiguration configuration)
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
        /// [EXPERIMENTAL] GetCertificates: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format)  Lists all the certificates previously minted to which you have access.  The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized 
        /// </summary>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ICollection&lt;CertificateState&gt;</returns>
        public ICollection<CertificateState> GetCertificates()
        {
            Finbourne.Luminesce.Sdk.Client.ApiResponse<ICollection<CertificateState>> localVarResponse = GetCertificatesWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EXPERIMENTAL] GetCertificates: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format)  Lists all the certificates previously minted to which you have access.  The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized 
        /// </summary>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ICollection&lt;CertificateState&gt;</returns>
        public Finbourne.Luminesce.Sdk.Client.ApiResponse<ICollection<CertificateState>> GetCertificatesWithHttpInfo()
        {
            Finbourne.Luminesce.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Luminesce.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Finbourne.Luminesce.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Finbourne.Luminesce.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.14.136");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ICollection<CertificateState>>("/api/Certificate/certificates", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCertificates", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EXPERIMENTAL] GetCertificates: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format)  Lists all the certificates previously minted to which you have access.  The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized 
        /// </summary>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ICollection&lt;CertificateState&gt;</returns>
        public async System.Threading.Tasks.Task<ICollection<CertificateState>> GetCertificatesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Finbourne.Luminesce.Sdk.Client.ApiResponse<ICollection<CertificateState>> localVarResponse = await GetCertificatesWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EXPERIMENTAL] GetCertificates: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format)  Lists all the certificates previously minted to which you have access.  The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized 
        /// </summary>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ICollection&lt;CertificateState&gt;)</returns>
        public async System.Threading.Tasks.Task<Finbourne.Luminesce.Sdk.Client.ApiResponse<ICollection<CertificateState>>> GetCertificatesWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Finbourne.Luminesce.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Luminesce.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };


            var localVarContentType = Finbourne.Luminesce.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Finbourne.Luminesce.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.14.136");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ICollection<CertificateState>>("/api/Certificate/certificates", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCertificates", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EXPERIMENTAL] ManageCertificate: Manages a new certificate (Create / Renew / Revoke)  Manages a certificate.  This could be creating a new one, renewing an old one or revoking one explicitly.  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something about the request cannot be processed - 401 Unauthorized 
        /// </summary>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="action">The Action to perform, e.g. Create / Renew / Revoke (optional)</param>
        /// <param name="type">User or Domain level cert (Domain level requires additional entitlements) (optional)</param>
        /// <param name="version">Version number of the cert, the request will fail to validate if incorrect (optional, default to 1)</param>
        /// <param name="validityStart">When should the cert first be valid (defaults to the current time in UTC) (optional)</param>
        /// <param name="validityEnd">When should the cert no longer be valid (defaults to 13 months from now) (optional)</param>
        /// <param name="dryRun">True will just validate the request, but perform no changes to any system (optional, default to true)</param>
        /// <returns>CertificateState</returns>
        public CertificateState ManageCertificate(CertificateAction? action = default(CertificateAction?), CertificateType? type = default(CertificateType?), int? version = default(int?), DateTimeOffset? validityStart = default(DateTimeOffset?), DateTimeOffset? validityEnd = default(DateTimeOffset?), bool? dryRun = default(bool?))
        {
            Finbourne.Luminesce.Sdk.Client.ApiResponse<CertificateState> localVarResponse = ManageCertificateWithHttpInfo(action, type, version, validityStart, validityEnd, dryRun);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EXPERIMENTAL] ManageCertificate: Manages a new certificate (Create / Renew / Revoke)  Manages a certificate.  This could be creating a new one, renewing an old one or revoking one explicitly.  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something about the request cannot be processed - 401 Unauthorized 
        /// </summary>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="action">The Action to perform, e.g. Create / Renew / Revoke (optional)</param>
        /// <param name="type">User or Domain level cert (Domain level requires additional entitlements) (optional)</param>
        /// <param name="version">Version number of the cert, the request will fail to validate if incorrect (optional, default to 1)</param>
        /// <param name="validityStart">When should the cert first be valid (defaults to the current time in UTC) (optional)</param>
        /// <param name="validityEnd">When should the cert no longer be valid (defaults to 13 months from now) (optional)</param>
        /// <param name="dryRun">True will just validate the request, but perform no changes to any system (optional, default to true)</param>
        /// <returns>ApiResponse of CertificateState</returns>
        public Finbourne.Luminesce.Sdk.Client.ApiResponse<CertificateState> ManageCertificateWithHttpInfo(CertificateAction? action = default(CertificateAction?), CertificateType? type = default(CertificateType?), int? version = default(int?), DateTimeOffset? validityStart = default(DateTimeOffset?), DateTimeOffset? validityEnd = default(DateTimeOffset?), bool? dryRun = default(bool?))
        {
            Finbourne.Luminesce.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Luminesce.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Finbourne.Luminesce.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Finbourne.Luminesce.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (action != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Luminesce.Sdk.Client.ClientUtils.ParameterToMultiMap("", "action", action));
            }
            if (type != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Luminesce.Sdk.Client.ClientUtils.ParameterToMultiMap("", "type", type));
            }
            if (version != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Luminesce.Sdk.Client.ClientUtils.ParameterToMultiMap("", "version", version));
            }
            if (validityStart != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Luminesce.Sdk.Client.ClientUtils.ParameterToMultiMap("", "validityStart", validityStart));
            }
            if (validityEnd != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Luminesce.Sdk.Client.ClientUtils.ParameterToMultiMap("", "validityEnd", validityEnd));
            }
            if (dryRun != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Luminesce.Sdk.Client.ClientUtils.ParameterToMultiMap("", "dryRun", dryRun));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.14.136");

            // make the HTTP request
            var localVarResponse = this.Client.Put<CertificateState>("/api/Certificate/manage", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ManageCertificate", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EXPERIMENTAL] ManageCertificate: Manages a new certificate (Create / Renew / Revoke)  Manages a certificate.  This could be creating a new one, renewing an old one or revoking one explicitly.  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something about the request cannot be processed - 401 Unauthorized 
        /// </summary>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="action">The Action to perform, e.g. Create / Renew / Revoke (optional)</param>
        /// <param name="type">User or Domain level cert (Domain level requires additional entitlements) (optional)</param>
        /// <param name="version">Version number of the cert, the request will fail to validate if incorrect (optional, default to 1)</param>
        /// <param name="validityStart">When should the cert first be valid (defaults to the current time in UTC) (optional)</param>
        /// <param name="validityEnd">When should the cert no longer be valid (defaults to 13 months from now) (optional)</param>
        /// <param name="dryRun">True will just validate the request, but perform no changes to any system (optional, default to true)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CertificateState</returns>
        public async System.Threading.Tasks.Task<CertificateState> ManageCertificateAsync(CertificateAction? action = default(CertificateAction?), CertificateType? type = default(CertificateType?), int? version = default(int?), DateTimeOffset? validityStart = default(DateTimeOffset?), DateTimeOffset? validityEnd = default(DateTimeOffset?), bool? dryRun = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Finbourne.Luminesce.Sdk.Client.ApiResponse<CertificateState> localVarResponse = await ManageCertificateWithHttpInfoAsync(action, type, version, validityStart, validityEnd, dryRun, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EXPERIMENTAL] ManageCertificate: Manages a new certificate (Create / Renew / Revoke)  Manages a certificate.  This could be creating a new one, renewing an old one or revoking one explicitly.  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something about the request cannot be processed - 401 Unauthorized 
        /// </summary>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="action">The Action to perform, e.g. Create / Renew / Revoke (optional)</param>
        /// <param name="type">User or Domain level cert (Domain level requires additional entitlements) (optional)</param>
        /// <param name="version">Version number of the cert, the request will fail to validate if incorrect (optional, default to 1)</param>
        /// <param name="validityStart">When should the cert first be valid (defaults to the current time in UTC) (optional)</param>
        /// <param name="validityEnd">When should the cert no longer be valid (defaults to 13 months from now) (optional)</param>
        /// <param name="dryRun">True will just validate the request, but perform no changes to any system (optional, default to true)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CertificateState)</returns>
        public async System.Threading.Tasks.Task<Finbourne.Luminesce.Sdk.Client.ApiResponse<CertificateState>> ManageCertificateWithHttpInfoAsync(CertificateAction? action = default(CertificateAction?), CertificateType? type = default(CertificateType?), int? version = default(int?), DateTimeOffset? validityStart = default(DateTimeOffset?), DateTimeOffset? validityEnd = default(DateTimeOffset?), bool? dryRun = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Finbourne.Luminesce.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Luminesce.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };


            var localVarContentType = Finbourne.Luminesce.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Finbourne.Luminesce.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (action != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Luminesce.Sdk.Client.ClientUtils.ParameterToMultiMap("", "action", action));
            }
            if (type != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Luminesce.Sdk.Client.ClientUtils.ParameterToMultiMap("", "type", type));
            }
            if (version != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Luminesce.Sdk.Client.ClientUtils.ParameterToMultiMap("", "version", version));
            }
            if (validityStart != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Luminesce.Sdk.Client.ClientUtils.ParameterToMultiMap("", "validityStart", validityStart));
            }
            if (validityEnd != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Luminesce.Sdk.Client.ClientUtils.ParameterToMultiMap("", "validityEnd", validityEnd));
            }
            if (dryRun != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Luminesce.Sdk.Client.ClientUtils.ParameterToMultiMap("", "dryRun", dryRun));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.14.136");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<CertificateState>("/api/Certificate/manage", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ManageCertificate", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}