/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.14.12
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
    public interface ICurrentTableFieldCatalogApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// GetCatalog: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format)
        /// </summary>
        /// <remarks>
        ///  The following LuminesceSql is executed to return this information:  &#x60;&#x60;&#x60;sql @reg &#x3D; select     Name,     min(Description) as Description,     min(DocumentationLink) as DocumentationLink,     iif(Category &#x3D; &#39;View&#39; and Client is not null, true, false) as IsView from     Sys.Registration where     Type in (&#39;DirectProvider&#39;, &#39;DataProvider&#39;)     and      ShowAll &#x3D; false group by     1     ;  @fld &#x3D; select     TableName,     FieldName,     DataType,     FieldType,     IsPrimaryKey,     IsMain,     Description,     ParamDefaultValue,     TableParamColumns from     Sys.Field     ;  @x &#x3D; select     coalesce(f.TableName, r.Name) as TableName,     coalesce(f.FieldName, &#39;N/A&#39;) as FieldName,     f.DataType,     f.FieldType,     f.IsPrimaryKey,     f.IsMain,     case          when f.TableName is not null then             f.Description         else             r.Name || &#39; returns a different set of columns depending on use.&#39;         end as Description,     f.ParamDefaultValue,     f.TableParamColumns,     r.Description as ProviderDescription,     r.DocumentationLink,     r.IsView from     @reg r     left outer join @fld f         on r.Name &#x3D; f.TableName order by     1, 5 desc, 6 desc, 2     ;     &#x60;&#x60;&#x60;  The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized 
        /// </remarks>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="freeTextSearch">Limit the catalog to only things in some way dealing with the passed in text string (optional)</param>
        /// <param name="jsonProper">Should this be text/json (not json-encoded-as-a-string) (optional, default to false)</param>
        /// <returns>string</returns>
        string GetCatalog(string freeTextSearch = default(string), bool? jsonProper = default(bool?));

        /// <summary>
        /// GetCatalog: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format)
        /// </summary>
        /// <remarks>
        ///  The following LuminesceSql is executed to return this information:  &#x60;&#x60;&#x60;sql @reg &#x3D; select     Name,     min(Description) as Description,     min(DocumentationLink) as DocumentationLink,     iif(Category &#x3D; &#39;View&#39; and Client is not null, true, false) as IsView from     Sys.Registration where     Type in (&#39;DirectProvider&#39;, &#39;DataProvider&#39;)     and      ShowAll &#x3D; false group by     1     ;  @fld &#x3D; select     TableName,     FieldName,     DataType,     FieldType,     IsPrimaryKey,     IsMain,     Description,     ParamDefaultValue,     TableParamColumns from     Sys.Field     ;  @x &#x3D; select     coalesce(f.TableName, r.Name) as TableName,     coalesce(f.FieldName, &#39;N/A&#39;) as FieldName,     f.DataType,     f.FieldType,     f.IsPrimaryKey,     f.IsMain,     case          when f.TableName is not null then             f.Description         else             r.Name || &#39; returns a different set of columns depending on use.&#39;         end as Description,     f.ParamDefaultValue,     f.TableParamColumns,     r.Description as ProviderDescription,     r.DocumentationLink,     r.IsView from     @reg r     left outer join @fld f         on r.Name &#x3D; f.TableName order by     1, 5 desc, 6 desc, 2     ;     &#x60;&#x60;&#x60;  The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized 
        /// </remarks>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="freeTextSearch">Limit the catalog to only things in some way dealing with the passed in text string (optional)</param>
        /// <param name="jsonProper">Should this be text/json (not json-encoded-as-a-string) (optional, default to false)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> GetCatalogWithHttpInfo(string freeTextSearch = default(string), bool? jsonProper = default(bool?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICurrentTableFieldCatalogApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// GetCatalog: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format)
        /// </summary>
        /// <remarks>
        ///  The following LuminesceSql is executed to return this information:  &#x60;&#x60;&#x60;sql @reg &#x3D; select     Name,     min(Description) as Description,     min(DocumentationLink) as DocumentationLink,     iif(Category &#x3D; &#39;View&#39; and Client is not null, true, false) as IsView from     Sys.Registration where     Type in (&#39;DirectProvider&#39;, &#39;DataProvider&#39;)     and      ShowAll &#x3D; false group by     1     ;  @fld &#x3D; select     TableName,     FieldName,     DataType,     FieldType,     IsPrimaryKey,     IsMain,     Description,     ParamDefaultValue,     TableParamColumns from     Sys.Field     ;  @x &#x3D; select     coalesce(f.TableName, r.Name) as TableName,     coalesce(f.FieldName, &#39;N/A&#39;) as FieldName,     f.DataType,     f.FieldType,     f.IsPrimaryKey,     f.IsMain,     case          when f.TableName is not null then             f.Description         else             r.Name || &#39; returns a different set of columns depending on use.&#39;         end as Description,     f.ParamDefaultValue,     f.TableParamColumns,     r.Description as ProviderDescription,     r.DocumentationLink,     r.IsView from     @reg r     left outer join @fld f         on r.Name &#x3D; f.TableName order by     1, 5 desc, 6 desc, 2     ;     &#x60;&#x60;&#x60;  The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized 
        /// </remarks>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="freeTextSearch">Limit the catalog to only things in some way dealing with the passed in text string (optional)</param>
        /// <param name="jsonProper">Should this be text/json (not json-encoded-as-a-string) (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> GetCatalogAsync(string freeTextSearch = default(string), bool? jsonProper = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// GetCatalog: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format)
        /// </summary>
        /// <remarks>
        ///  The following LuminesceSql is executed to return this information:  &#x60;&#x60;&#x60;sql @reg &#x3D; select     Name,     min(Description) as Description,     min(DocumentationLink) as DocumentationLink,     iif(Category &#x3D; &#39;View&#39; and Client is not null, true, false) as IsView from     Sys.Registration where     Type in (&#39;DirectProvider&#39;, &#39;DataProvider&#39;)     and      ShowAll &#x3D; false group by     1     ;  @fld &#x3D; select     TableName,     FieldName,     DataType,     FieldType,     IsPrimaryKey,     IsMain,     Description,     ParamDefaultValue,     TableParamColumns from     Sys.Field     ;  @x &#x3D; select     coalesce(f.TableName, r.Name) as TableName,     coalesce(f.FieldName, &#39;N/A&#39;) as FieldName,     f.DataType,     f.FieldType,     f.IsPrimaryKey,     f.IsMain,     case          when f.TableName is not null then             f.Description         else             r.Name || &#39; returns a different set of columns depending on use.&#39;         end as Description,     f.ParamDefaultValue,     f.TableParamColumns,     r.Description as ProviderDescription,     r.DocumentationLink,     r.IsView from     @reg r     left outer join @fld f         on r.Name &#x3D; f.TableName order by     1, 5 desc, 6 desc, 2     ;     &#x60;&#x60;&#x60;  The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized 
        /// </remarks>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="freeTextSearch">Limit the catalog to only things in some way dealing with the passed in text string (optional)</param>
        /// <param name="jsonProper">Should this be text/json (not json-encoded-as-a-string) (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> GetCatalogWithHttpInfoAsync(string freeTextSearch = default(string), bool? jsonProper = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICurrentTableFieldCatalogApi : ICurrentTableFieldCatalogApiSync, ICurrentTableFieldCatalogApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CurrentTableFieldCatalogApi : ICurrentTableFieldCatalogApi
    {
        private Finbourne.Luminesce.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentTableFieldCatalogApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CurrentTableFieldCatalogApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentTableFieldCatalogApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CurrentTableFieldCatalogApi(String basePath)
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
        /// Initializes a new instance of the <see cref="CurrentTableFieldCatalogApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CurrentTableFieldCatalogApi(Finbourne.Luminesce.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = configuration;
            this.Client = new Finbourne.Luminesce.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Finbourne.Luminesce.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Finbourne.Luminesce.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentTableFieldCatalogApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public CurrentTableFieldCatalogApi(Finbourne.Luminesce.Sdk.Client.ISynchronousClient client, Finbourne.Luminesce.Sdk.Client.IAsynchronousClient asyncClient, Finbourne.Luminesce.Sdk.Client.IReadableConfiguration configuration)
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
        /// GetCatalog: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format)  The following LuminesceSql is executed to return this information:  &#x60;&#x60;&#x60;sql @reg &#x3D; select     Name,     min(Description) as Description,     min(DocumentationLink) as DocumentationLink,     iif(Category &#x3D; &#39;View&#39; and Client is not null, true, false) as IsView from     Sys.Registration where     Type in (&#39;DirectProvider&#39;, &#39;DataProvider&#39;)     and      ShowAll &#x3D; false group by     1     ;  @fld &#x3D; select     TableName,     FieldName,     DataType,     FieldType,     IsPrimaryKey,     IsMain,     Description,     ParamDefaultValue,     TableParamColumns from     Sys.Field     ;  @x &#x3D; select     coalesce(f.TableName, r.Name) as TableName,     coalesce(f.FieldName, &#39;N/A&#39;) as FieldName,     f.DataType,     f.FieldType,     f.IsPrimaryKey,     f.IsMain,     case          when f.TableName is not null then             f.Description         else             r.Name || &#39; returns a different set of columns depending on use.&#39;         end as Description,     f.ParamDefaultValue,     f.TableParamColumns,     r.Description as ProviderDescription,     r.DocumentationLink,     r.IsView from     @reg r     left outer join @fld f         on r.Name &#x3D; f.TableName order by     1, 5 desc, 6 desc, 2     ;     &#x60;&#x60;&#x60;  The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized 
        /// </summary>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="freeTextSearch">Limit the catalog to only things in some way dealing with the passed in text string (optional)</param>
        /// <param name="jsonProper">Should this be text/json (not json-encoded-as-a-string) (optional, default to false)</param>
        /// <returns>string</returns>
        public string GetCatalog(string freeTextSearch = default(string), bool? jsonProper = default(bool?))
        {
            Finbourne.Luminesce.Sdk.Client.ApiResponse<string> localVarResponse = GetCatalogWithHttpInfo(freeTextSearch, jsonProper);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetCatalog: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format)  The following LuminesceSql is executed to return this information:  &#x60;&#x60;&#x60;sql @reg &#x3D; select     Name,     min(Description) as Description,     min(DocumentationLink) as DocumentationLink,     iif(Category &#x3D; &#39;View&#39; and Client is not null, true, false) as IsView from     Sys.Registration where     Type in (&#39;DirectProvider&#39;, &#39;DataProvider&#39;)     and      ShowAll &#x3D; false group by     1     ;  @fld &#x3D; select     TableName,     FieldName,     DataType,     FieldType,     IsPrimaryKey,     IsMain,     Description,     ParamDefaultValue,     TableParamColumns from     Sys.Field     ;  @x &#x3D; select     coalesce(f.TableName, r.Name) as TableName,     coalesce(f.FieldName, &#39;N/A&#39;) as FieldName,     f.DataType,     f.FieldType,     f.IsPrimaryKey,     f.IsMain,     case          when f.TableName is not null then             f.Description         else             r.Name || &#39; returns a different set of columns depending on use.&#39;         end as Description,     f.ParamDefaultValue,     f.TableParamColumns,     r.Description as ProviderDescription,     r.DocumentationLink,     r.IsView from     @reg r     left outer join @fld f         on r.Name &#x3D; f.TableName order by     1, 5 desc, 6 desc, 2     ;     &#x60;&#x60;&#x60;  The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized 
        /// </summary>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="freeTextSearch">Limit the catalog to only things in some way dealing with the passed in text string (optional)</param>
        /// <param name="jsonProper">Should this be text/json (not json-encoded-as-a-string) (optional, default to false)</param>
        /// <returns>ApiResponse of string</returns>
        public Finbourne.Luminesce.Sdk.Client.ApiResponse<string> GetCatalogWithHttpInfo(string freeTextSearch = default(string), bool? jsonProper = default(bool?))
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

            if (freeTextSearch != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Luminesce.Sdk.Client.ClientUtils.ParameterToMultiMap("", "freeTextSearch", freeTextSearch));
            }
            if (jsonProper != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Luminesce.Sdk.Client.ClientUtils.ParameterToMultiMap("", "jsonProper", jsonProper));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.14.12");

            // make the HTTP request
            var localVarResponse = this.Client.Get<string>("/api/Catalog", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCatalog", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// GetCatalog: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format)  The following LuminesceSql is executed to return this information:  &#x60;&#x60;&#x60;sql @reg &#x3D; select     Name,     min(Description) as Description,     min(DocumentationLink) as DocumentationLink,     iif(Category &#x3D; &#39;View&#39; and Client is not null, true, false) as IsView from     Sys.Registration where     Type in (&#39;DirectProvider&#39;, &#39;DataProvider&#39;)     and      ShowAll &#x3D; false group by     1     ;  @fld &#x3D; select     TableName,     FieldName,     DataType,     FieldType,     IsPrimaryKey,     IsMain,     Description,     ParamDefaultValue,     TableParamColumns from     Sys.Field     ;  @x &#x3D; select     coalesce(f.TableName, r.Name) as TableName,     coalesce(f.FieldName, &#39;N/A&#39;) as FieldName,     f.DataType,     f.FieldType,     f.IsPrimaryKey,     f.IsMain,     case          when f.TableName is not null then             f.Description         else             r.Name || &#39; returns a different set of columns depending on use.&#39;         end as Description,     f.ParamDefaultValue,     f.TableParamColumns,     r.Description as ProviderDescription,     r.DocumentationLink,     r.IsView from     @reg r     left outer join @fld f         on r.Name &#x3D; f.TableName order by     1, 5 desc, 6 desc, 2     ;     &#x60;&#x60;&#x60;  The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized 
        /// </summary>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="freeTextSearch">Limit the catalog to only things in some way dealing with the passed in text string (optional)</param>
        /// <param name="jsonProper">Should this be text/json (not json-encoded-as-a-string) (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> GetCatalogAsync(string freeTextSearch = default(string), bool? jsonProper = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Finbourne.Luminesce.Sdk.Client.ApiResponse<string> localVarResponse = await GetCatalogWithHttpInfoAsync(freeTextSearch, jsonProper, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GetCatalog: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format)  The following LuminesceSql is executed to return this information:  &#x60;&#x60;&#x60;sql @reg &#x3D; select     Name,     min(Description) as Description,     min(DocumentationLink) as DocumentationLink,     iif(Category &#x3D; &#39;View&#39; and Client is not null, true, false) as IsView from     Sys.Registration where     Type in (&#39;DirectProvider&#39;, &#39;DataProvider&#39;)     and      ShowAll &#x3D; false group by     1     ;  @fld &#x3D; select     TableName,     FieldName,     DataType,     FieldType,     IsPrimaryKey,     IsMain,     Description,     ParamDefaultValue,     TableParamColumns from     Sys.Field     ;  @x &#x3D; select     coalesce(f.TableName, r.Name) as TableName,     coalesce(f.FieldName, &#39;N/A&#39;) as FieldName,     f.DataType,     f.FieldType,     f.IsPrimaryKey,     f.IsMain,     case          when f.TableName is not null then             f.Description         else             r.Name || &#39; returns a different set of columns depending on use.&#39;         end as Description,     f.ParamDefaultValue,     f.TableParamColumns,     r.Description as ProviderDescription,     r.DocumentationLink,     r.IsView from     @reg r     left outer join @fld f         on r.Name &#x3D; f.TableName order by     1, 5 desc, 6 desc, 2     ;     &#x60;&#x60;&#x60;  The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized 
        /// </summary>
        /// <exception cref="Finbourne.Luminesce.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="freeTextSearch">Limit the catalog to only things in some way dealing with the passed in text string (optional)</param>
        /// <param name="jsonProper">Should this be text/json (not json-encoded-as-a-string) (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<Finbourne.Luminesce.Sdk.Client.ApiResponse<string>> GetCatalogWithHttpInfoAsync(string freeTextSearch = default(string), bool? jsonProper = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            if (freeTextSearch != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Luminesce.Sdk.Client.ClientUtils.ParameterToMultiMap("", "freeTextSearch", freeTextSearch));
            }
            if (jsonProper != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Luminesce.Sdk.Client.ClientUtils.ParameterToMultiMap("", "jsonProper", jsonProper));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "1.14.12");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<string>("/api/Catalog", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCatalog", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}