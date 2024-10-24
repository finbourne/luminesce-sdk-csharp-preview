/*
 * FINBOURNE Luminesce Web API
 *
 *  ``` >   __                    _                             / /   __  ______ ___  (_)___  ___  _____________    / /   / / / / __ `__ / / __ / _ / ___/ ___/ _ \\  / /___/ /_/ / / / / / / / / / /  __(__  ) /__/  __/ /_____/\\__,_/_/ /_/ /_/_/_/ /_/\\___/____/\\___/\\___/  ```  ### Introduction to Luminesce   [Luminesce](https://support.lusid.com/knowledgebase/article/KA-01677/) is a data virtualization engine for LUSID and other applications.  It is proprietary technology designed and developed by FINBOURNE Technology Limited.  [Understanding the Luminesce platform architecture.](https://support.lusid.com/knowledgebase/article/KA-01707/)  Luminesce enables you to query multiple sources of business intelligence simultaneously in real-time—including investment management data stored in LUSID itself—and build a consolidated picture for analysis, optionally writing data back into LUSID. Alternatively, you can use Luminesce in a standalone capacity, without interacting with LUSID at all.  ### WebAPI  Allows for running queries and a variety of other functions relating to Luminesce. For example these REST APIs can execute queries, synchronously or better asynchronously, returning results in either Excel, CSV, SqLite, JSON among other formats.  ### Error Codes  | Code|Meaning | | - --|- -- | | <a name=\"233\">233</a>|Query Parser Failure | | <a name=\"850\">850</a>|Required provider not visible; provider may not exist, be temporarily unavailable, or you may not have the necessary permissions | | <a name=\"851\">851</a>|Query reached a timeout period or was cancelled | | <a name=\"852\">852</a>|Query failed during execution | | <a name=\"853\">853</a>|Query failed during execution for an unexpected reason | | <a name=\"854\">854</a>|Query failed during execution for a reason known to be an internal error (e.g. a Lusid provider where a corresponding API would return a 500) | | <a name=\"855\">855</a>|Required column is not in the queried provider(s) | | <a name=\"856\">856</a>|One or more columns are ambiguously referenced in the query | | <a name=\"857\">857</a>|Query failed during execution of a provider (e.g. in a way that might be transient, like an upstream issue) | | <a name=\"858\">858</a>|Query failed during execution within the Query Engine's SQL processing | | <a name=\"859\">859</a>|A variable has been defined more than once | 
 *
 * The version of the OpenAPI document: 1.16.765
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

namespace Finbourne.Luminesce.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IHealthCheckingEndpointApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [INTERNAL] FakeNodeReclaim: Helps testing of AWS node reclaim behaviour
        /// </summary>
        /// <remarks>
        ///  An internal Method used to mark the next SIGTERM as though an Aws Node reclaim were about to take place. Simulates having received an AWS node reclaim warning, or similar.
        /// </remarks>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="secondsUntilReclaim">the number of seconds from which to assume node termination (optional, default to 119)</param>
        /// <returns>Object</returns>
        Object FakeNodeReclaim(int? secondsUntilReclaim = default(int?));

        /// <summary>
        /// [INTERNAL] FakeNodeReclaim: Helps testing of AWS node reclaim behaviour
        /// </summary>
        /// <remarks>
        ///  An internal Method used to mark the next SIGTERM as though an Aws Node reclaim were about to take place. Simulates having received an AWS node reclaim warning, or similar.
        /// </remarks>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="secondsUntilReclaim">the number of seconds from which to assume node termination (optional, default to 119)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> FakeNodeReclaimWithHttpInfo(int? secondsUntilReclaim = default(int?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IHealthCheckingEndpointApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// [INTERNAL] FakeNodeReclaim: Helps testing of AWS node reclaim behaviour
        /// </summary>
        /// <remarks>
        ///  An internal Method used to mark the next SIGTERM as though an Aws Node reclaim were about to take place. Simulates having received an AWS node reclaim warning, or similar.
        /// </remarks>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="secondsUntilReclaim">the number of seconds from which to assume node termination (optional, default to 119)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> FakeNodeReclaimAsync(int? secondsUntilReclaim = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [INTERNAL] FakeNodeReclaim: Helps testing of AWS node reclaim behaviour
        /// </summary>
        /// <remarks>
        ///  An internal Method used to mark the next SIGTERM as though an Aws Node reclaim were about to take place. Simulates having received an AWS node reclaim warning, or similar.
        /// </remarks>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="secondsUntilReclaim">the number of seconds from which to assume node termination (optional, default to 119)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> FakeNodeReclaimWithHttpInfoAsync(int? secondsUntilReclaim = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IHealthCheckingEndpointApi : IHealthCheckingEndpointApiSync, IHealthCheckingEndpointApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class HealthCheckingEndpointApi : IHealthCheckingEndpointApi
    {
        private Finbourne.Luminesce.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthCheckingEndpointApi"/> class.
        /// </summary>
        /// <returns></returns>
        public HealthCheckingEndpointApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthCheckingEndpointApi"/> class.
        /// </summary>
        /// <returns></returns>
        public HealthCheckingEndpointApi(String basePath)
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
        /// Initializes a new instance of the <see cref="HealthCheckingEndpointApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public HealthCheckingEndpointApi(Finbourne.Luminesce.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = configuration;
            this.Client = new Finbourne.Luminesce.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Finbourne.Luminesce.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Finbourne.Luminesce.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthCheckingEndpointApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public HealthCheckingEndpointApi(Finbourne.Luminesce.Sdk.Client.ISynchronousClient client, Finbourne.Luminesce.Sdk.Client.IAsynchronousClient asyncClient, Finbourne.Luminesce.Sdk.Client.IReadableConfiguration configuration)
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
        /// [INTERNAL] FakeNodeReclaim: Helps testing of AWS node reclaim behaviour  An internal Method used to mark the next SIGTERM as though an Aws Node reclaim were about to take place. Simulates having received an AWS node reclaim warning, or similar.
        /// </summary>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="secondsUntilReclaim">the number of seconds from which to assume node termination (optional, default to 119)</param>
        /// <returns>Object</returns>
        public Object FakeNodeReclaim(int? secondsUntilReclaim = default(int?))
        {
            Finbourne.Luminesce.Sdk.Client.ApiResponse<Object> localVarResponse = FakeNodeReclaimWithHttpInfo(secondsUntilReclaim);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [INTERNAL] FakeNodeReclaim: Helps testing of AWS node reclaim behaviour  An internal Method used to mark the next SIGTERM as though an Aws Node reclaim were about to take place. Simulates having received an AWS node reclaim warning, or similar.
        /// </summary>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="secondsUntilReclaim">the number of seconds from which to assume node termination (optional, default to 119)</param>
        /// <returns>ApiResponse of Object</returns>
        public Finbourne.Luminesce.Sdk.Client.ApiResponse<Object> FakeNodeReclaimWithHttpInfo(int? secondsUntilReclaim = default(int?))
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

            if (secondsUntilReclaim != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Luminesce.Sdk.Client.ClientUtils.ParameterToMultiMap("", "secondsUntilReclaim", secondsUntilReclaim));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.16.765");

            // make the HTTP request
            var localVarResponse = this.Client.Get<Object>("/fakeNodeReclaim", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FakeNodeReclaim", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [INTERNAL] FakeNodeReclaim: Helps testing of AWS node reclaim behaviour  An internal Method used to mark the next SIGTERM as though an Aws Node reclaim were about to take place. Simulates having received an AWS node reclaim warning, or similar.
        /// </summary>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="secondsUntilReclaim">the number of seconds from which to assume node termination (optional, default to 119)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> FakeNodeReclaimAsync(int? secondsUntilReclaim = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Finbourne.Luminesce.Sdk.Client.ApiResponse<Object> localVarResponse = await FakeNodeReclaimWithHttpInfoAsync(secondsUntilReclaim, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [INTERNAL] FakeNodeReclaim: Helps testing of AWS node reclaim behaviour  An internal Method used to mark the next SIGTERM as though an Aws Node reclaim were about to take place. Simulates having received an AWS node reclaim warning, or similar.
        /// </summary>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="secondsUntilReclaim">the number of seconds from which to assume node termination (optional, default to 119)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<Finbourne.Luminesce.Sdk.Client.ApiResponse<Object>> FakeNodeReclaimWithHttpInfoAsync(int? secondsUntilReclaim = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            if (secondsUntilReclaim != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Luminesce.Sdk.Client.ClientUtils.ParameterToMultiMap("", "secondsUntilReclaim", secondsUntilReclaim));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.16.765");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Object>("/fakeNodeReclaim", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FakeNodeReclaim", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}