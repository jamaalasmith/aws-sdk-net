/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Threading;

using Amazon.SimpleNotificationService.Model;
using Amazon.SimpleNotificationService.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.SimpleNotificationService
{
    /// <summary>
    /// Implementation for accessing AmazonSimpleNotificationService.
    ///  
    /// Amazon Simple Notification Service <para>Amazon Simple Notification Service (Amazon SNS) is a web service that enables you to build
    /// distributed web-enabled applications. Applications can use Amazon SNS to easily push real-time notification messages to interested
    /// subscribers over multiple delivery protocols. For more information about this product see http://aws.amazon.com/sns. For detailed
    /// information about Amazon SNS features and their associated API calls, see the Amazon SNS Getting Started Guide. </para> <para>We also
    /// provide SDKs that enable you to access Amazon SNS from your preferred programming language. The SDKs contain functionality that
    /// automatically takes care of tasks such as: cryptographically signing your service requests, retrying requests, and handling error responses.
    /// For a list of available SDKs, go to Tools for Amazon Web Services. </para>
    /// </summary>
    public partial class AmazonSimpleNotificationServiceClient : AmazonWebServiceClient, IAmazonSimpleNotificationService
    {
    QueryStringSigner signer = new QueryStringSigner();

        #region Constructors

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonSimpleNotificationServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleNotificationServiceConfig(), true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleNotificationServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleNotificationServiceConfig(){RegionEndpoint = region}, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonSimpleNotificationService Configuration Object</param>
        public AmazonSimpleNotificationServiceClient(AmazonSimpleNotificationServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSimpleNotificationServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonSimpleNotificationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleNotificationServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSimpleNotificationServiceConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Credentials and an
        /// AmazonSimpleNotificationServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSimpleNotificationServiceClient Configuration Object</param>
        public AmazonSimpleNotificationServiceClient(AWSCredentials credentials, AmazonSimpleNotificationServiceConfig clientConfig)
            : base(credentials, clientConfig, false, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSimpleNotificationServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleNotificationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleNotificationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleNotificationServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleNotificationServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSimpleNotificationServiceClient Configuration Object</param>
        public AmazonSimpleNotificationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSimpleNotificationServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSimpleNotificationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleNotificationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleNotificationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleNotificationServiceConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleNotificationServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSimpleNotificationServiceClient Configuration Object</param>
        public AmazonSimpleNotificationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSimpleNotificationServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion


        #region AddPermission

        /// <summary>
        /// <para>The <c>AddPermission</c> action adds a statement to a topic's access control policy, granting access for the specified AWS accounts to
        /// the specified actions.</para>
        /// </summary>
        /// 
        /// <param name="addPermissionRequest">Container for the necessary parameters to execute the AddPermission service method on
        ///          AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="NotFoundException"/>
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        public AddPermissionResponse AddPermission(AddPermissionRequest addPermissionRequest)
        {
            IAsyncResult asyncResult = invokeAddPermission(addPermissionRequest, null, null, true);
            return EndAddPermission(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AddPermission operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.AddPermission"/>
        /// </summary>
        /// 
        /// <param name="addPermissionRequest">Container for the necessary parameters to execute the AddPermission operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginAddPermission(AddPermissionRequest addPermissionRequest, AsyncCallback callback, object state)
        {
            return invokeAddPermission(addPermissionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AddPermission operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.AddPermission"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddPermission.</param>
        public AddPermissionResponse EndAddPermission(IAsyncResult asyncResult)
        {
            return endOperation<AddPermissionResponse>(asyncResult);
        }
        
        IAsyncResult invokeAddPermission(AddPermissionRequest addPermissionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AddPermissionRequestMarshaller().Marshall(addPermissionRequest);
            var unmarshaller = AddPermissionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ConfirmSubscription

        /// <summary>
        /// <para>The <c>ConfirmSubscription</c> action verifies an endpoint owner's intent to receive messages by validating the token sent to the
        /// endpoint by an earlier <c>Subscribe</c> action. If the token is valid, the action creates a new subscription and returns its Amazon Resource
        /// Name (ARN). This call requires an AWS signature only when the <c>AuthenticateOnUnsubscribe</c> flag is set to "true".</para>
        /// </summary>
        /// 
        /// <param name="confirmSubscriptionRequest">Container for the necessary parameters to execute the ConfirmSubscription service method on
        ///          AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the ConfirmSubscription service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="NotFoundException"/>
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="SubscriptionLimitExceededException"/>
        /// <exception cref="InvalidParameterException"/>
        public ConfirmSubscriptionResponse ConfirmSubscription(ConfirmSubscriptionRequest confirmSubscriptionRequest)
        {
            IAsyncResult asyncResult = invokeConfirmSubscription(confirmSubscriptionRequest, null, null, true);
            return EndConfirmSubscription(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmSubscription operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.ConfirmSubscription"/>
        /// </summary>
        /// 
        /// <param name="confirmSubscriptionRequest">Container for the necessary parameters to execute the ConfirmSubscription operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndConfirmSubscription operation.</returns>
        public IAsyncResult BeginConfirmSubscription(ConfirmSubscriptionRequest confirmSubscriptionRequest, AsyncCallback callback, object state)
        {
            return invokeConfirmSubscription(confirmSubscriptionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ConfirmSubscription operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.ConfirmSubscription"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfirmSubscription.</param>
        /// 
        /// <returns>Returns a ConfirmSubscriptionResult from AmazonSimpleNotificationService.</returns>
        public ConfirmSubscriptionResponse EndConfirmSubscription(IAsyncResult asyncResult)
        {
            return endOperation<ConfirmSubscriptionResponse>(asyncResult);
        }
        
        IAsyncResult invokeConfirmSubscription(ConfirmSubscriptionRequest confirmSubscriptionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ConfirmSubscriptionRequestMarshaller().Marshall(confirmSubscriptionRequest);
            var unmarshaller = ConfirmSubscriptionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateTopic

        /// <summary>
        /// <para>The <c>CreateTopic</c> action creates a topic to which notifications can be published. Users can create at most 100 topics. For more
        /// information, see http://aws.amazon.com/sns. This action is idempotent, so if the requester already owns a topic with the specified name,
        /// that topic's ARN is returned without creating a new topic.</para>
        /// </summary>
        /// 
        /// <param name="createTopicRequest">Container for the necessary parameters to execute the CreateTopic service method on
        ///          AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the CreateTopic service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        /// <exception cref="TopicLimitExceededException"/>
        public CreateTopicResponse CreateTopic(CreateTopicRequest createTopicRequest)
        {
            IAsyncResult asyncResult = invokeCreateTopic(createTopicRequest, null, null, true);
            return EndCreateTopic(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTopic operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.CreateTopic"/>
        /// </summary>
        /// 
        /// <param name="createTopicRequest">Container for the necessary parameters to execute the CreateTopic operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTopic
        ///         operation.</returns>
        public IAsyncResult BeginCreateTopic(CreateTopicRequest createTopicRequest, AsyncCallback callback, object state)
        {
            return invokeCreateTopic(createTopicRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateTopic operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.CreateTopic"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTopic.</param>
        /// 
        /// <returns>Returns a CreateTopicResult from AmazonSimpleNotificationService.</returns>
        public CreateTopicResponse EndCreateTopic(IAsyncResult asyncResult)
        {
            return endOperation<CreateTopicResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateTopic(CreateTopicRequest createTopicRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateTopicRequestMarshaller().Marshall(createTopicRequest);
            var unmarshaller = CreateTopicResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteTopic

        /// <summary>
        /// <para>The <c>DeleteTopic</c> action deletes a topic and all its subscriptions. Deleting a topic might prevent some messages previously sent
        /// to the topic from being delivered to subscribers. This action is idempotent, so deleting a topic that does not exist does not result in an
        /// error.</para>
        /// </summary>
        /// 
        /// <param name="deleteTopicRequest">Container for the necessary parameters to execute the DeleteTopic service method on
        ///          AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="NotFoundException"/>
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        public DeleteTopicResponse DeleteTopic(DeleteTopicRequest deleteTopicRequest)
        {
            IAsyncResult asyncResult = invokeDeleteTopic(deleteTopicRequest, null, null, true);
            return EndDeleteTopic(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTopic operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.DeleteTopic"/>
        /// </summary>
        /// 
        /// <param name="deleteTopicRequest">Container for the necessary parameters to execute the DeleteTopic operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteTopic(DeleteTopicRequest deleteTopicRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteTopic(deleteTopicRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteTopic operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.DeleteTopic"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTopic.</param>
        public DeleteTopicResponse EndDeleteTopic(IAsyncResult asyncResult)
        {
            return endOperation<DeleteTopicResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteTopic(DeleteTopicRequest deleteTopicRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteTopicRequestMarshaller().Marshall(deleteTopicRequest);
            var unmarshaller = DeleteTopicResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetSubscriptionAttributes

        /// <summary>
        /// <para>The <c>GetSubscriptionAttribtues</c> action returns all of the properties of a subscription.</para>
        /// </summary>
        /// 
        /// <param name="getSubscriptionAttributesRequest">Container for the necessary parameters to execute the GetSubscriptionAttributes service
        ///          method on AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the GetSubscriptionAttributes service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="NotFoundException"/>
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        public GetSubscriptionAttributesResponse GetSubscriptionAttributes(GetSubscriptionAttributesRequest getSubscriptionAttributesRequest)
        {
            IAsyncResult asyncResult = invokeGetSubscriptionAttributes(getSubscriptionAttributesRequest, null, null, true);
            return EndGetSubscriptionAttributes(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetSubscriptionAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.GetSubscriptionAttributes"/>
        /// </summary>
        /// 
        /// <param name="getSubscriptionAttributesRequest">Container for the necessary parameters to execute the GetSubscriptionAttributes operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetSubscriptionAttributes operation.</returns>
        public IAsyncResult BeginGetSubscriptionAttributes(GetSubscriptionAttributesRequest getSubscriptionAttributesRequest, AsyncCallback callback, object state)
        {
            return invokeGetSubscriptionAttributes(getSubscriptionAttributesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetSubscriptionAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.GetSubscriptionAttributes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSubscriptionAttributes.</param>
        /// 
        /// <returns>Returns a GetSubscriptionAttributesResult from AmazonSimpleNotificationService.</returns>
        public GetSubscriptionAttributesResponse EndGetSubscriptionAttributes(IAsyncResult asyncResult)
        {
            return endOperation<GetSubscriptionAttributesResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetSubscriptionAttributes(GetSubscriptionAttributesRequest getSubscriptionAttributesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetSubscriptionAttributesRequestMarshaller().Marshall(getSubscriptionAttributesRequest);
            var unmarshaller = GetSubscriptionAttributesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetTopicAttributes

        /// <summary>
        /// <para>The <c>GetTopicAttributes</c> action returns all of the properties of a topic. Topic properties returned might differ based on the
        /// authorization of the user. </para>
        /// </summary>
        /// 
        /// <param name="getTopicAttributesRequest">Container for the necessary parameters to execute the GetTopicAttributes service method on
        ///          AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the GetTopicAttributes service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="NotFoundException"/>
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        public GetTopicAttributesResponse GetTopicAttributes(GetTopicAttributesRequest getTopicAttributesRequest)
        {
            IAsyncResult asyncResult = invokeGetTopicAttributes(getTopicAttributesRequest, null, null, true);
            return EndGetTopicAttributes(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetTopicAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.GetTopicAttributes"/>
        /// </summary>
        /// 
        /// <param name="getTopicAttributesRequest">Container for the necessary parameters to execute the GetTopicAttributes operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetTopicAttributes operation.</returns>
        public IAsyncResult BeginGetTopicAttributes(GetTopicAttributesRequest getTopicAttributesRequest, AsyncCallback callback, object state)
        {
            return invokeGetTopicAttributes(getTopicAttributesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetTopicAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.GetTopicAttributes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTopicAttributes.</param>
        /// 
        /// <returns>Returns a GetTopicAttributesResult from AmazonSimpleNotificationService.</returns>
        public GetTopicAttributesResponse EndGetTopicAttributes(IAsyncResult asyncResult)
        {
            return endOperation<GetTopicAttributesResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetTopicAttributes(GetTopicAttributesRequest getTopicAttributesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetTopicAttributesRequestMarshaller().Marshall(getTopicAttributesRequest);
            var unmarshaller = GetTopicAttributesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListSubscriptions

        /// <summary>
        /// <para>The <c>ListSubscriptions</c> action returns a list of the requester's subscriptions. Each call returns a limited list of
        /// subscriptions, up to 100. If there are more subscriptions, a <c>NextToken</c> is also returned. Use the <c>NextToken</c> parameter in a new
        /// <c>ListSubscriptions</c> call to get further results.</para>
        /// </summary>
        /// 
        /// <param name="listSubscriptionsRequest">Container for the necessary parameters to execute the ListSubscriptions service method on
        ///          AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the ListSubscriptions service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        public ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsRequest listSubscriptionsRequest)
        {
            IAsyncResult asyncResult = invokeListSubscriptions(listSubscriptionsRequest, null, null, true);
            return EndListSubscriptions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListSubscriptions operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.ListSubscriptions"/>
        /// </summary>
        /// 
        /// <param name="listSubscriptionsRequest">Container for the necessary parameters to execute the ListSubscriptions operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSubscriptions
        ///         operation.</returns>
        public IAsyncResult BeginListSubscriptions(ListSubscriptionsRequest listSubscriptionsRequest, AsyncCallback callback, object state)
        {
            return invokeListSubscriptions(listSubscriptionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListSubscriptions operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.ListSubscriptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSubscriptions.</param>
        /// 
        /// <returns>Returns a ListSubscriptionsResult from AmazonSimpleNotificationService.</returns>
        public ListSubscriptionsResponse EndListSubscriptions(IAsyncResult asyncResult)
        {
            return endOperation<ListSubscriptionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeListSubscriptions(ListSubscriptionsRequest listSubscriptionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListSubscriptionsRequestMarshaller().Marshall(listSubscriptionsRequest);
            var unmarshaller = ListSubscriptionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>The <c>ListSubscriptions</c> action returns a list of the requester's subscriptions. Each call returns a limited list of
        /// subscriptions, up to 100. If there are more subscriptions, a <c>NextToken</c> is also returned. Use the <c>NextToken</c> parameter in a new
        /// <c>ListSubscriptions</c> call to get further results.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListSubscriptions service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        public ListSubscriptionsResponse ListSubscriptions()
        {
            return ListSubscriptions(new ListSubscriptionsRequest());
        }
        

        #endregion
    
        #region ListSubscriptionsByTopic

        /// <summary>
        /// <para>The <c>ListSubscriptionsByTopic</c> action returns a list of the subscriptions to a specific topic. Each call returns a limited list
        /// of subscriptions, up to 100. If there are more subscriptions, a <c>NextToken</c> is also returned. Use the <c>NextToken</c> parameter in a
        /// new <c>ListSubscriptionsByTopic</c> call to get further results.</para>
        /// </summary>
        /// 
        /// <param name="listSubscriptionsByTopicRequest">Container for the necessary parameters to execute the ListSubscriptionsByTopic service method
        ///          on AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the ListSubscriptionsByTopic service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="NotFoundException"/>
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        public ListSubscriptionsByTopicResponse ListSubscriptionsByTopic(ListSubscriptionsByTopicRequest listSubscriptionsByTopicRequest)
        {
            IAsyncResult asyncResult = invokeListSubscriptionsByTopic(listSubscriptionsByTopicRequest, null, null, true);
            return EndListSubscriptionsByTopic(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListSubscriptionsByTopic operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.ListSubscriptionsByTopic"/>
        /// </summary>
        /// 
        /// <param name="listSubscriptionsByTopicRequest">Container for the necessary parameters to execute the ListSubscriptionsByTopic operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListSubscriptionsByTopic operation.</returns>
        public IAsyncResult BeginListSubscriptionsByTopic(ListSubscriptionsByTopicRequest listSubscriptionsByTopicRequest, AsyncCallback callback, object state)
        {
            return invokeListSubscriptionsByTopic(listSubscriptionsByTopicRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListSubscriptionsByTopic operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.ListSubscriptionsByTopic"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSubscriptionsByTopic.</param>
        /// 
        /// <returns>Returns a ListSubscriptionsByTopicResult from AmazonSimpleNotificationService.</returns>
        public ListSubscriptionsByTopicResponse EndListSubscriptionsByTopic(IAsyncResult asyncResult)
        {
            return endOperation<ListSubscriptionsByTopicResponse>(asyncResult);
        }
        
        IAsyncResult invokeListSubscriptionsByTopic(ListSubscriptionsByTopicRequest listSubscriptionsByTopicRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListSubscriptionsByTopicRequestMarshaller().Marshall(listSubscriptionsByTopicRequest);
            var unmarshaller = ListSubscriptionsByTopicResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListTopics

        /// <summary>
        /// <para>The <c>ListTopics</c> action returns a list of the requester's topics. Each call returns a limited list of topics, up to 100. If there
        /// are more topics, a <c>NextToken</c> is also returned. Use the <c>NextToken</c> parameter in a new <c>ListTopics</c> call to get further
        /// results.</para>
        /// </summary>
        /// 
        /// <param name="listTopicsRequest">Container for the necessary parameters to execute the ListTopics service method on
        ///          AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the ListTopics service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        public ListTopicsResponse ListTopics(ListTopicsRequest listTopicsRequest)
        {
            IAsyncResult asyncResult = invokeListTopics(listTopicsRequest, null, null, true);
            return EndListTopics(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListTopics operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.ListTopics"/>
        /// </summary>
        /// 
        /// <param name="listTopicsRequest">Container for the necessary parameters to execute the ListTopics operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTopics
        ///         operation.</returns>
        public IAsyncResult BeginListTopics(ListTopicsRequest listTopicsRequest, AsyncCallback callback, object state)
        {
            return invokeListTopics(listTopicsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListTopics operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.ListTopics"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTopics.</param>
        /// 
        /// <returns>Returns a ListTopicsResult from AmazonSimpleNotificationService.</returns>
        public ListTopicsResponse EndListTopics(IAsyncResult asyncResult)
        {
            return endOperation<ListTopicsResponse>(asyncResult);
        }
        
        IAsyncResult invokeListTopics(ListTopicsRequest listTopicsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListTopicsRequestMarshaller().Marshall(listTopicsRequest);
            var unmarshaller = ListTopicsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>The <c>ListTopics</c> action returns a list of the requester's topics. Each call returns a limited list of topics, up to 100. If there
        /// are more topics, a <c>NextToken</c> is also returned. Use the <c>NextToken</c> parameter in a new <c>ListTopics</c> call to get further
        /// results.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListTopics service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        public ListTopicsResponse ListTopics()
        {
            return ListTopics(new ListTopicsRequest());
        }
        

        #endregion
    
        #region Publish

        /// <summary>
        /// <para>The <c>Publish</c> action sends a message to all of a topic's subscribed endpoints. When a <c>messageId</c> is returned, the message
        /// has been saved and Amazon SNS will attempt to deliver it to the topic's subscribers shortly. The format of the outgoing message to each
        /// subscribed endpoint depends on the notification protocol selected.</para>
        /// </summary>
        /// 
        /// <param name="publishRequest">Container for the necessary parameters to execute the Publish service method on
        ///          AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the Publish service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="NotFoundException"/>
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        public PublishResponse Publish(PublishRequest publishRequest)
        {
            IAsyncResult asyncResult = invokePublish(publishRequest, null, null, true);
            return EndPublish(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the Publish operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.Publish"/>
        /// </summary>
        /// 
        /// <param name="publishRequest">Container for the necessary parameters to execute the Publish operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPublish
        ///         operation.</returns>
        public IAsyncResult BeginPublish(PublishRequest publishRequest, AsyncCallback callback, object state)
        {
            return invokePublish(publishRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the Publish operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.Publish"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPublish.</param>
        /// 
        /// <returns>Returns a PublishResult from AmazonSimpleNotificationService.</returns>
        public PublishResponse EndPublish(IAsyncResult asyncResult)
        {
            return endOperation<PublishResponse>(asyncResult);
        }
        
        IAsyncResult invokePublish(PublishRequest publishRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PublishRequestMarshaller().Marshall(publishRequest);
            var unmarshaller = PublishResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RemovePermission

        /// <summary>
        /// <para>The <c>RemovePermission</c> action removes a statement from a topic's access control policy.</para>
        /// </summary>
        /// 
        /// <param name="removePermissionRequest">Container for the necessary parameters to execute the RemovePermission service method on
        ///          AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="NotFoundException"/>
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        public RemovePermissionResponse RemovePermission(RemovePermissionRequest removePermissionRequest)
        {
            IAsyncResult asyncResult = invokeRemovePermission(removePermissionRequest, null, null, true);
            return EndRemovePermission(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RemovePermission operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.RemovePermission"/>
        /// </summary>
        /// 
        /// <param name="removePermissionRequest">Container for the necessary parameters to execute the RemovePermission operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginRemovePermission(RemovePermissionRequest removePermissionRequest, AsyncCallback callback, object state)
        {
            return invokeRemovePermission(removePermissionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RemovePermission operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.RemovePermission"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemovePermission.</param>
        public RemovePermissionResponse EndRemovePermission(IAsyncResult asyncResult)
        {
            return endOperation<RemovePermissionResponse>(asyncResult);
        }
        
        IAsyncResult invokeRemovePermission(RemovePermissionRequest removePermissionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RemovePermissionRequestMarshaller().Marshall(removePermissionRequest);
            var unmarshaller = RemovePermissionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region SetSubscriptionAttributes

        /// <summary>
        /// <para>The <c>SetSubscriptionAttributes</c> action allows a subscription owner to set an attribute of the topic to a new value.</para>
        /// </summary>
        /// 
        /// <param name="setSubscriptionAttributesRequest">Container for the necessary parameters to execute the SetSubscriptionAttributes service
        ///          method on AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="NotFoundException"/>
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        public SetSubscriptionAttributesResponse SetSubscriptionAttributes(SetSubscriptionAttributesRequest setSubscriptionAttributesRequest)
        {
            IAsyncResult asyncResult = invokeSetSubscriptionAttributes(setSubscriptionAttributesRequest, null, null, true);
            return EndSetSubscriptionAttributes(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the SetSubscriptionAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.SetSubscriptionAttributes"/>
        /// </summary>
        /// 
        /// <param name="setSubscriptionAttributesRequest">Container for the necessary parameters to execute the SetSubscriptionAttributes operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginSetSubscriptionAttributes(SetSubscriptionAttributesRequest setSubscriptionAttributesRequest, AsyncCallback callback, object state)
        {
            return invokeSetSubscriptionAttributes(setSubscriptionAttributesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the SetSubscriptionAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.SetSubscriptionAttributes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetSubscriptionAttributes.</param>
        public SetSubscriptionAttributesResponse EndSetSubscriptionAttributes(IAsyncResult asyncResult)
        {
            return endOperation<SetSubscriptionAttributesResponse>(asyncResult);
        }
        
        IAsyncResult invokeSetSubscriptionAttributes(SetSubscriptionAttributesRequest setSubscriptionAttributesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SetSubscriptionAttributesRequestMarshaller().Marshall(setSubscriptionAttributesRequest);
            var unmarshaller = SetSubscriptionAttributesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region SetTopicAttributes

        /// <summary>
        /// <para>The <c>SetTopicAttributes</c> action allows a topic owner to set an attribute of the topic to a new value.</para>
        /// </summary>
        /// 
        /// <param name="setTopicAttributesRequest">Container for the necessary parameters to execute the SetTopicAttributes service method on
        ///          AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="NotFoundException"/>
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        public SetTopicAttributesResponse SetTopicAttributes(SetTopicAttributesRequest setTopicAttributesRequest)
        {
            IAsyncResult asyncResult = invokeSetTopicAttributes(setTopicAttributesRequest, null, null, true);
            return EndSetTopicAttributes(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the SetTopicAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.SetTopicAttributes"/>
        /// </summary>
        /// 
        /// <param name="setTopicAttributesRequest">Container for the necessary parameters to execute the SetTopicAttributes operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginSetTopicAttributes(SetTopicAttributesRequest setTopicAttributesRequest, AsyncCallback callback, object state)
        {
            return invokeSetTopicAttributes(setTopicAttributesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the SetTopicAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.SetTopicAttributes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetTopicAttributes.</param>
        public SetTopicAttributesResponse EndSetTopicAttributes(IAsyncResult asyncResult)
        {
            return endOperation<SetTopicAttributesResponse>(asyncResult);
        }
        
        IAsyncResult invokeSetTopicAttributes(SetTopicAttributesRequest setTopicAttributesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SetTopicAttributesRequestMarshaller().Marshall(setTopicAttributesRequest);
            var unmarshaller = SetTopicAttributesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region Subscribe

        /// <summary>
        /// <para>The <c>Subscribe</c> action prepares to subscribe an endpoint by sending the endpoint a confirmation message. To actually create a
        /// subscription, the endpoint owner must call the <c>ConfirmSubscription</c> action with the token from the confirmation message. Confirmation
        /// tokens are valid for three days.</para>
        /// </summary>
        /// 
        /// <param name="subscribeRequest">Container for the necessary parameters to execute the Subscribe service method on
        ///          AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the Subscribe service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="NotFoundException"/>
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="SubscriptionLimitExceededException"/>
        /// <exception cref="InvalidParameterException"/>
        public SubscribeResponse Subscribe(SubscribeRequest subscribeRequest)
        {
            IAsyncResult asyncResult = invokeSubscribe(subscribeRequest, null, null, true);
            return EndSubscribe(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the Subscribe operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.Subscribe"/>
        /// </summary>
        /// 
        /// <param name="subscribeRequest">Container for the necessary parameters to execute the Subscribe operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSubscribe
        ///         operation.</returns>
        public IAsyncResult BeginSubscribe(SubscribeRequest subscribeRequest, AsyncCallback callback, object state)
        {
            return invokeSubscribe(subscribeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the Subscribe operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.Subscribe"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSubscribe.</param>
        /// 
        /// <returns>Returns a SubscribeResult from AmazonSimpleNotificationService.</returns>
        public SubscribeResponse EndSubscribe(IAsyncResult asyncResult)
        {
            return endOperation<SubscribeResponse>(asyncResult);
        }
        
        IAsyncResult invokeSubscribe(SubscribeRequest subscribeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SubscribeRequestMarshaller().Marshall(subscribeRequest);
            var unmarshaller = SubscribeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region Unsubscribe

        /// <summary>
        /// <para>The <c>Unsubscribe</c> action deletes a subscription. If the subscription requires authentication for deletion, only the owner of the
        /// subscription or the topic's owner can unsubscribe, and an AWS signature is required. If the <c>Unsubscribe</c> call does not require
        /// authentication and the requester is not the subscription owner, a final cancellation message is delivered to the endpoint, so that the
        /// endpoint owner can easily resubscribe to the topic if the <c>Unsubscribe</c> request was unintended.</para>
        /// </summary>
        /// 
        /// <param name="unsubscribeRequest">Container for the necessary parameters to execute the Unsubscribe service method on
        ///          AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="NotFoundException"/>
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        public UnsubscribeResponse Unsubscribe(UnsubscribeRequest unsubscribeRequest)
        {
            IAsyncResult asyncResult = invokeUnsubscribe(unsubscribeRequest, null, null, true);
            return EndUnsubscribe(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the Unsubscribe operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.Unsubscribe"/>
        /// </summary>
        /// 
        /// <param name="unsubscribeRequest">Container for the necessary parameters to execute the Unsubscribe operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginUnsubscribe(UnsubscribeRequest unsubscribeRequest, AsyncCallback callback, object state)
        {
            return invokeUnsubscribe(unsubscribeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the Unsubscribe operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.Unsubscribe"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnsubscribe.</param>
        public UnsubscribeResponse EndUnsubscribe(IAsyncResult asyncResult)
        {
            return endOperation<UnsubscribeResponse>(asyncResult);
        }
        
        IAsyncResult invokeUnsubscribe(UnsubscribeRequest unsubscribeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UnsubscribeRequestMarshaller().Marshall(unsubscribeRequest);
            var unmarshaller = UnsubscribeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
    }
}
    
