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
using System.Threading.Tasks;

using Amazon.ElasticLoadBalancing.Model;
using Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticLoadBalancing
{
    /// <summary>
    /// Implementation for accessing AmazonElasticLoadBalancing.
    /// 
    /// Elastic Load Balancing <para> Elastic Load Balancing is a cost-effective and easy to use web service to help you improve the availability
    /// and scalability of your application running on Amazon Elastic Cloud Compute (Amazon EC2). It makes it easy for you to distribute application
    /// loads between two or more EC2 instances. Elastic Load Balancing supports the growth in traffic of your application by enabling availability
    /// through redundancy. </para> <para>This guide provides detailed information about Elastic Load Balancing actions, data types, and parameters
    /// that can be used for sending a query request. Query requests are HTTP or HTTPS requests that use the HTTP verb GET or POST and a query
    /// parameter named Action or Operation. Action is used throughout this documentation, although Operation is supported for backward
    /// compatibility with other AWS Query APIs.</para> <para>For detailed information on constructing a query request using the actions, data
    /// types, and parameters mentioned in this guide, go to Using the Query API in the <i>Elastic Load Balancing Developer Guide</i> .</para>
    /// <para>For detailed information about Elastic Load Balancing features and their associated actions, go to Using Elastic Load Balancing in the
    /// <i>Elastic Load Balancing Developer Guide</i> .</para> <para>This reference guide is based on the current WSDL, which is available at:
    /// </para>
    /// </summary>
    /// <summary>
    /// Implementation for accessing AmazonElasticLoadBalancing.
    /// 
    /// Elastic Load Balancing <para> Elastic Load Balancing is a cost-effective and easy to use web service to help you improve the availability
    /// and scalability of your application running on Amazon Elastic Cloud Compute (Amazon EC2). It makes it easy for you to distribute application
    /// loads between two or more EC2 instances. Elastic Load Balancing supports the growth in traffic of your application by enabling availability
    /// through redundancy. </para> <para>This guide provides detailed information about Elastic Load Balancing actions, data types, and parameters
    /// that can be used for sending a query request. Query requests are HTTP or HTTPS requests that use the HTTP verb GET or POST and a query
    /// parameter named Action or Operation. Action is used throughout this documentation, although Operation is supported for backward
    /// compatibility with other AWS Query APIs.</para> <para>For detailed information on constructing a query request using the actions, data
    /// types, and parameters mentioned in this guide, go to Using the Query API in the <i>Elastic Load Balancing Developer Guide</i> .</para>
    /// <para>For detailed information about Elastic Load Balancing features and their associated actions, go to Using Elastic Load Balancing in the
    /// <i>Elastic Load Balancing Developer Guide</i> .</para> <para>This reference guide is based on the current WSDL, which is available at:
    /// </para>
    /// </summary>
	public partial class AmazonElasticLoadBalancingClient : AmazonWebServiceClient, Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing
	{

		AWS4Signer signer = new AWS4Signer();
        #region Constructors

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with the credentials loaded from the application's
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
        public AmazonElasticLoadBalancingClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticLoadBalancingConfig(), true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with the credentials loaded from the application's
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
        public AmazonElasticLoadBalancingClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticLoadBalancingConfig(){RegionEndpoint = region}, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonElasticLoadBalancing Configuration Object</param>
        public AmazonElasticLoadBalancingClient(AmazonElasticLoadBalancingConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonElasticLoadBalancingClient(AWSCredentials credentials)
            : this(credentials, new AmazonElasticLoadBalancingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticLoadBalancingClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonElasticLoadBalancingConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Credentials and an
        /// AmazonElasticLoadBalancingClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonElasticLoadBalancingClient Configuration Object</param>
        public AmazonElasticLoadBalancingClient(AWSCredentials credentials, AmazonElasticLoadBalancingConfig clientConfig)
            : base(credentials, clientConfig, false, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticLoadBalancingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticLoadBalancingConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticLoadBalancingClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonElasticLoadBalancingClient Configuration Object</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonElasticLoadBalancingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticLoadBalancingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticLoadBalancingConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticLoadBalancingClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonElasticLoadBalancingClient Configuration Object</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonElasticLoadBalancingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

 
        /// <summary>
        /// <para> Associates one or more security groups with your LoadBalancer in VPC. The provided security group IDs will override any currently
        /// applied security groups. </para>
        /// </summary>
        /// 
        /// <param name="applySecurityGroupsToLoadBalancerRequest">Container for the necessary parameters to execute the
        /// ApplySecurityGroupsToLoadBalancer service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the ApplySecurityGroupsToLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidSecurityGroupException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
		public ApplySecurityGroupsToLoadBalancerResponse ApplySecurityGroupsToLoadBalancer(ApplySecurityGroupsToLoadBalancerRequest request)
		{
			var task = ApplySecurityGroupsToLoadBalancerAsync(request);
			try
			{
				return task.Result;
			}
			catch(AggregateException e)
			{
				throw e.InnerException;
			}
		}
          
        /// <summary>
        /// Initiates the asynchronous execution of the ApplySecurityGroupsToLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.ApplySecurityGroupsToLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ApplySecurityGroupsToLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ApplySecurityGroupsToLoadBalancerResponse> ApplySecurityGroupsToLoadBalancerAsync(ApplySecurityGroupsToLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new ApplySecurityGroupsToLoadBalancerRequestMarshaller();
			var unmarshaller = ApplySecurityGroupsToLoadBalancerResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, ApplySecurityGroupsToLoadBalancerRequest, ApplySecurityGroupsToLoadBalancerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para> Adds one or more subnets to the set of configured subnets in the VPC for the LoadBalancer. </para> <para> The Loadbalancers evenly
        /// distribute requests across all of the registered subnets. </para>
        /// </summary>
        /// 
        /// <param name="attachLoadBalancerToSubnetsRequest">Container for the necessary parameters to execute the AttachLoadBalancerToSubnets service
        /// method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the AttachLoadBalancerToSubnets service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidSubnetException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.SubnetNotFoundException" />
		public AttachLoadBalancerToSubnetsResponse AttachLoadBalancerToSubnets(AttachLoadBalancerToSubnetsRequest request)
		{
			var task = AttachLoadBalancerToSubnetsAsync(request);
			try
			{
				return task.Result;
			}
			catch(AggregateException e)
			{
				throw e.InnerException;
			}
		}
          
        /// <summary>
        /// Initiates the asynchronous execution of the AttachLoadBalancerToSubnets operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.AttachLoadBalancerToSubnets"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancerToSubnets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<AttachLoadBalancerToSubnetsResponse> AttachLoadBalancerToSubnetsAsync(AttachLoadBalancerToSubnetsRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new AttachLoadBalancerToSubnetsRequestMarshaller();
			var unmarshaller = AttachLoadBalancerToSubnetsResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, AttachLoadBalancerToSubnetsRequest, AttachLoadBalancerToSubnetsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para> Enables the client to define an application healthcheck for the instances. </para>
        /// </summary>
        /// 
        /// <param name="configureHealthCheckRequest">Container for the necessary parameters to execute the ConfigureHealthCheck service method on
        /// AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the ConfigureHealthCheck service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
		public ConfigureHealthCheckResponse ConfigureHealthCheck(ConfigureHealthCheckRequest request)
		{
			var task = ConfigureHealthCheckAsync(request);
			try
			{
				return task.Result;
			}
			catch(AggregateException e)
			{
				throw e.InnerException;
			}
		}
          
        /// <summary>
        /// Initiates the asynchronous execution of the ConfigureHealthCheck operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.ConfigureHealthCheck"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfigureHealthCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ConfigureHealthCheckResponse> ConfigureHealthCheckAsync(ConfigureHealthCheckRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new ConfigureHealthCheckRequestMarshaller();
			var unmarshaller = ConfigureHealthCheckResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, ConfigureHealthCheckRequest, ConfigureHealthCheckResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para> Generates a stickiness policy with sticky session lifetimes that follow that of an application-generated cookie. This policy can be
        /// associated only with HTTP/HTTPS listeners. </para> <para> This policy is similar to the policy created by CreateLBCookieStickinessPolicy,
        /// except that the lifetime of the special Elastic Load Balancing cookie follows the lifetime of the application-generated cookie specified in
        /// the policy configuration. The LoadBalancer only inserts a new stickiness cookie when the application response includes a new application
        /// cookie. </para> <para> If the application cookie is explicitly removed or expires, the session stops being sticky until a new application
        /// cookie is issued. </para> <para><b>NOTE:</b> An application client must receive and send two cookies: the application-generated cookie and
        /// the special Elastic Load Balancing cookie named AWSELB. This is the default behavior for many common web browsers. </para> <para>For
        /// information on using CreateAppCookieStickinessPolicy, see <i>Using the Query API</i> in the Enabling Application-Controlled Sesssion
        /// Stickiness section of the <i>Elastic Load Balancing Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createAppCookieStickinessPolicyRequest">Container for the necessary parameters to execute the CreateAppCookieStickinessPolicy
        /// service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the CreateAppCookieStickinessPolicy service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.DuplicatePolicyNameException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.TooManyPoliciesException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
		public CreateAppCookieStickinessPolicyResponse CreateAppCookieStickinessPolicy(CreateAppCookieStickinessPolicyRequest request)
		{
			var task = CreateAppCookieStickinessPolicyAsync(request);
			try
			{
				return task.Result;
			}
			catch(AggregateException e)
			{
				throw e.InnerException;
			}
		}
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateAppCookieStickinessPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.CreateAppCookieStickinessPolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAppCookieStickinessPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CreateAppCookieStickinessPolicyResponse> CreateAppCookieStickinessPolicyAsync(CreateAppCookieStickinessPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new CreateAppCookieStickinessPolicyRequestMarshaller();
			var unmarshaller = CreateAppCookieStickinessPolicyResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, CreateAppCookieStickinessPolicyRequest, CreateAppCookieStickinessPolicyResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para> Generates a stickiness policy with sticky session lifetimes controlled by the lifetime of the browser (user-agent) or a specified
        /// expiration period. This policy can be associated only with HTTP/HTTPS listeners. </para> <para> When a LoadBalancer implements this policy,
        /// the LoadBalancer uses a special cookie to track the backend server instance for each request. When the LoadBalancer receives a request, it
        /// first checks to see if this cookie is present in the request. If so, the LoadBalancer sends the request to the application server specified
        /// in the cookie. If not, the LoadBalancer sends the request to a server that is chosen based on the existing load balancing algorithm. </para>
        /// <para> A cookie is inserted into the response for binding subsequent requests from the same user to that server. The validity of the cookie
        /// is based on the cookie expiration time, which is specified in the policy configuration. </para> <para>For information on using
        /// CreateLBCookieStickinessPolicy, see <i>Using the Query API</i> in the Enabling Duration-Based Sesssion Stickiness section of the <i>Elastic
        /// Load Balancing Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createLBCookieStickinessPolicyRequest">Container for the necessary parameters to execute the CreateLBCookieStickinessPolicy
        /// service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the CreateLBCookieStickinessPolicy service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.DuplicatePolicyNameException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.TooManyPoliciesException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
		public CreateLBCookieStickinessPolicyResponse CreateLBCookieStickinessPolicy(CreateLBCookieStickinessPolicyRequest request)
		{
			var task = CreateLBCookieStickinessPolicyAsync(request);
			try
			{
				return task.Result;
			}
			catch(AggregateException e)
			{
				throw e.InnerException;
			}
		}
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateLBCookieStickinessPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.CreateLBCookieStickinessPolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLBCookieStickinessPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CreateLBCookieStickinessPolicyResponse> CreateLBCookieStickinessPolicyAsync(CreateLBCookieStickinessPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new CreateLBCookieStickinessPolicyRequestMarshaller();
			var unmarshaller = CreateLBCookieStickinessPolicyResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, CreateLBCookieStickinessPolicyRequest, CreateLBCookieStickinessPolicyResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para> Creates a new LoadBalancer. </para> <para> After the call has completed successfully, a new LoadBalancer is created; however, it will
        /// not be usable until at least one instance has been registered. When the LoadBalancer creation is completed, the client can check whether or
        /// not it is usable by using the DescribeInstanceHealth action. The LoadBalancer is usable as soon as any registered instance is
        /// <i>InService</i> .
        /// </para> <para><b>NOTE:</b> Currently, the client's quota of LoadBalancers is limited to ten per Region. </para> <para><b>NOTE:</b>
        /// LoadBalancer DNS names vary depending on the Region they're created in. For LoadBalancers created in the United States, the DNS name ends
        /// with: us-east-1.elb.amazonaws.com (for the Northern Virginia Region) us-west-1.elb.amazonaws.com (for the Northern California Region) For
        /// LoadBalancers created in the EU (Ireland) Region, the DNS name ends with: eu-west-1.elb.amazonaws.com </para> <para>For information on using
        /// CreateLoadBalancer to create a new LoadBalancer in Amazon EC2, go to Using Query API section in the <i>Creating a Load Balancer With SSL
        /// Cipher Settings and Back-end Authentication</i> topic of the <i>Elastic Load Balancing Developer Guide</i> .</para> <para>For information on
        /// using CreateLoadBalancer to create a new LoadBalancer in Amazon VPC, see <i>Using the Query API</i> in the Creating a Basic Load Balancer in
        /// Amazon VPC section in the <i>Elastic Load Balancing Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createLoadBalancerRequest">Container for the necessary parameters to execute the CreateLoadBalancer service method on
        /// AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the CreateLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidSubnetException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidSecurityGroupException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.CertificateNotFoundException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidSchemeException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.DuplicateLoadBalancerNameException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.TooManyLoadBalancersException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.SubnetNotFoundException" />
		public CreateLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest request)
		{
			var task = CreateLoadBalancerAsync(request);
			try
			{
				return task.Result;
			}
			catch(AggregateException e)
			{
				throw e.InnerException;
			}
		}
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.CreateLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CreateLoadBalancerResponse> CreateLoadBalancerAsync(CreateLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new CreateLoadBalancerRequestMarshaller();
			var unmarshaller = CreateLoadBalancerResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, CreateLoadBalancerRequest, CreateLoadBalancerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para> Creates one or more listeners on a LoadBalancer for the specified port. If a listener with the given port does not already exist, it
        /// will be created; otherwise, the properties of the new listener must match the properties of the existing listener. </para>
        /// </summary>
        /// 
        /// <param name="createLoadBalancerListenersRequest">Container for the necessary parameters to execute the CreateLoadBalancerListeners service
        /// method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the CreateLoadBalancerListeners service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.DuplicateListenerException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.CertificateNotFoundException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
		public CreateLoadBalancerListenersResponse CreateLoadBalancerListeners(CreateLoadBalancerListenersRequest request)
		{
			var task = CreateLoadBalancerListenersAsync(request);
			try
			{
				return task.Result;
			}
			catch(AggregateException e)
			{
				throw e.InnerException;
			}
		}
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancerListeners operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.CreateLoadBalancerListeners"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancerListeners operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CreateLoadBalancerListenersResponse> CreateLoadBalancerListenersAsync(CreateLoadBalancerListenersRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new CreateLoadBalancerListenersRequestMarshaller();
			var unmarshaller = CreateLoadBalancerListenersResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, CreateLoadBalancerListenersRequest, CreateLoadBalancerListenersResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para> Creates a new policy that contains the necessary attributes depending on the policy type. Policies are settings that are saved for
        /// your Elastic LoadBalancer and that can be applied to the front-end listener, or the back-end application server, depending on your policy
        /// type. </para>
        /// </summary>
        /// 
        /// <param name="createLoadBalancerPolicyRequest">Container for the necessary parameters to execute the CreateLoadBalancerPolicy service method
        /// on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the CreateLoadBalancerPolicy service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.PolicyTypeNotFoundException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.DuplicatePolicyNameException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.TooManyPoliciesException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
		public CreateLoadBalancerPolicyResponse CreateLoadBalancerPolicy(CreateLoadBalancerPolicyRequest request)
		{
			var task = CreateLoadBalancerPolicyAsync(request);
			try
			{
				return task.Result;
			}
			catch(AggregateException e)
			{
				throw e.InnerException;
			}
		}
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancerPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.CreateLoadBalancerPolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancerPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CreateLoadBalancerPolicyResponse> CreateLoadBalancerPolicyAsync(CreateLoadBalancerPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new CreateLoadBalancerPolicyRequestMarshaller();
			var unmarshaller = CreateLoadBalancerPolicyResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, CreateLoadBalancerPolicyRequest, CreateLoadBalancerPolicyResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para> Deletes the specified LoadBalancer. </para> <para> If attempting to recreate the LoadBalancer, the client must reconfigure all the
        /// settings. The DNS name associated with a deleted LoadBalancer will no longer be usable. Once deleted, the name and associated DNS record of
        /// the LoadBalancer no longer exist and traffic sent to any of its IP addresses will no longer be delivered to client instances. The client
        /// will not receive the same DNS name even if a new LoadBalancer with same LoadBalancerName is created. </para> <para> To successfully call
        /// this API, the client must provide the same account credentials as were used to create the LoadBalancer. </para> <para><b>NOTE:</b> By
        /// design, if the LoadBalancer does not exist or has already been deleted, DeleteLoadBalancer still succeeds. </para>
        /// </summary>
        /// 
        /// <param name="deleteLoadBalancerRequest">Container for the necessary parameters to execute the DeleteLoadBalancer service method on
        /// AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DeleteLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
		public DeleteLoadBalancerResponse DeleteLoadBalancer(DeleteLoadBalancerRequest request)
		{
			var task = DeleteLoadBalancerAsync(request);
			try
			{
				return task.Result;
			}
			catch(AggregateException e)
			{
				throw e.InnerException;
			}
		}
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.DeleteLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DeleteLoadBalancerResponse> DeleteLoadBalancerAsync(DeleteLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new DeleteLoadBalancerRequestMarshaller();
			var unmarshaller = DeleteLoadBalancerResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, DeleteLoadBalancerRequest, DeleteLoadBalancerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para> Deletes listeners from the LoadBalancer for the specified port. </para>
        /// </summary>
        /// 
        /// <param name="deleteLoadBalancerListenersRequest">Container for the necessary parameters to execute the DeleteLoadBalancerListeners service
        /// method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DeleteLoadBalancerListeners service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
		public DeleteLoadBalancerListenersResponse DeleteLoadBalancerListeners(DeleteLoadBalancerListenersRequest request)
		{
			var task = DeleteLoadBalancerListenersAsync(request);
			try
			{
				return task.Result;
			}
			catch(AggregateException e)
			{
				throw e.InnerException;
			}
		}
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancerListeners operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.DeleteLoadBalancerListeners"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerListeners operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DeleteLoadBalancerListenersResponse> DeleteLoadBalancerListenersAsync(DeleteLoadBalancerListenersRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new DeleteLoadBalancerListenersRequestMarshaller();
			var unmarshaller = DeleteLoadBalancerListenersResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, DeleteLoadBalancerListenersRequest, DeleteLoadBalancerListenersResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para> Deletes a policy from the LoadBalancer. The specified policy must not be enabled for any listeners. </para>
        /// </summary>
        /// 
        /// <param name="deleteLoadBalancerPolicyRequest">Container for the necessary parameters to execute the DeleteLoadBalancerPolicy service method
        /// on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DeleteLoadBalancerPolicy service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
		public DeleteLoadBalancerPolicyResponse DeleteLoadBalancerPolicy(DeleteLoadBalancerPolicyRequest request)
		{
			var task = DeleteLoadBalancerPolicyAsync(request);
			try
			{
				return task.Result;
			}
			catch(AggregateException e)
			{
				throw e.InnerException;
			}
		}
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancerPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.DeleteLoadBalancerPolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DeleteLoadBalancerPolicyResponse> DeleteLoadBalancerPolicyAsync(DeleteLoadBalancerPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new DeleteLoadBalancerPolicyRequestMarshaller();
			var unmarshaller = DeleteLoadBalancerPolicyResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, DeleteLoadBalancerPolicyRequest, DeleteLoadBalancerPolicyResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para> Deregisters instances from the LoadBalancer. Once the instance is deregistered, it will stop receiving traffic from the LoadBalancer.
        /// </para> <para> In order to successfully call this API, the same account credentials as those used to create the LoadBalancer must be
        /// provided. </para>
        /// </summary>
        /// 
        /// <param name="deregisterInstancesFromLoadBalancerRequest">Container for the necessary parameters to execute the
        /// DeregisterInstancesFromLoadBalancer service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DeregisterInstancesFromLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidInstanceException" />
		public DeregisterInstancesFromLoadBalancerResponse DeregisterInstancesFromLoadBalancer(DeregisterInstancesFromLoadBalancerRequest request)
		{
			var task = DeregisterInstancesFromLoadBalancerAsync(request);
			try
			{
				return task.Result;
			}
			catch(AggregateException e)
			{
				throw e.InnerException;
			}
		}
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterInstancesFromLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.DeregisterInstancesFromLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterInstancesFromLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DeregisterInstancesFromLoadBalancerResponse> DeregisterInstancesFromLoadBalancerAsync(DeregisterInstancesFromLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new DeregisterInstancesFromLoadBalancerRequestMarshaller();
			var unmarshaller = DeregisterInstancesFromLoadBalancerResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, DeregisterInstancesFromLoadBalancerRequest, DeregisterInstancesFromLoadBalancerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para> Returns the current state of the instances of the specified LoadBalancer. If no instances are specified, the state of all the
        /// instances for the LoadBalancer is returned. </para> <para><b>NOTE:</b> The client must have created the specified input LoadBalancer in
        /// order to retrieve this information; the client must provide the same account credentials as those that were used to create the LoadBalancer.
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeInstanceHealthRequest">Container for the necessary parameters to execute the DescribeInstanceHealth service method on
        /// AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DescribeInstanceHealth service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidInstanceException" />
		public DescribeInstanceHealthResponse DescribeInstanceHealth(DescribeInstanceHealthRequest request)
		{
			var task = DescribeInstanceHealthAsync(request);
			try
			{
				return task.Result;
			}
			catch(AggregateException e)
			{
				throw e.InnerException;
			}
		}
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceHealth operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.DescribeInstanceHealth"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceHealth operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeInstanceHealthResponse> DescribeInstanceHealthAsync(DescribeInstanceHealthRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new DescribeInstanceHealthRequestMarshaller();
			var unmarshaller = DescribeInstanceHealthResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, DescribeInstanceHealthRequest, DescribeInstanceHealthResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para>Returns detailed descriptions of the policies. If you specify a LoadBalancer name, the operation returns either the descriptions of
        /// the specified policies, or descriptions of all the policies created for the LoadBalancer. If you don't specify a LoadBalancer name, the
        /// operation returns descriptions of the specified sample policies, or descriptions of all the sample policies. The names of the sample
        /// policies have the <c>ELBSample-</c> prefix. </para>
        /// </summary>
        /// 
        /// <param name="describeLoadBalancerPoliciesRequest">Container for the necessary parameters to execute the DescribeLoadBalancerPolicies service
        /// method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicies service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.PolicyNotFoundException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
		public DescribeLoadBalancerPoliciesResponse DescribeLoadBalancerPolicies(DescribeLoadBalancerPoliciesRequest request)
		{
			var task = DescribeLoadBalancerPoliciesAsync(request);
			try
			{
				return task.Result;
			}
			catch(AggregateException e)
			{
				throw e.InnerException;
			}
		}
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerPolicies operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.DescribeLoadBalancerPolicies"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeLoadBalancerPoliciesResponse> DescribeLoadBalancerPoliciesAsync(DescribeLoadBalancerPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new DescribeLoadBalancerPoliciesRequestMarshaller();
			var unmarshaller = DescribeLoadBalancerPoliciesResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, DescribeLoadBalancerPoliciesRequest, DescribeLoadBalancerPoliciesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para>Returns detailed descriptions of the policies. If you specify a LoadBalancer name, the operation returns either the descriptions of
        /// the specified policies, or descriptions of all the policies created for the LoadBalancer. If you don't specify a LoadBalancer name, the
        /// operation returns descriptions of the specified sample policies, or descriptions of all the sample policies. The names of the sample
        /// policies have the <c>ELBSample-</c> prefix. </para>
        /// </summary>
        /// 
        /// <param name="describeLoadBalancerPoliciesRequest">Container for the necessary parameters to execute the DescribeLoadBalancerPolicies service
        /// method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicies service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.PolicyNotFoundException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
		public DescribeLoadBalancerPoliciesResponse DescribeLoadBalancerPolicies()
		{
			return this.DescribeLoadBalancerPolicies(new DescribeLoadBalancerPoliciesRequest());
		}
 
        /// <summary>
        /// <para> Returns meta-information on the specified LoadBalancer policies defined by the Elastic Load Balancing service. The policy types that
        /// are returned from this action can be used in a CreateLoadBalancerPolicy action to instantiate specific policy configurations that will be
        /// applied to an Elastic LoadBalancer. </para>
        /// </summary>
        /// 
        /// <param name="describeLoadBalancerPolicyTypesRequest">Container for the necessary parameters to execute the DescribeLoadBalancerPolicyTypes
        /// service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicyTypes service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.PolicyTypeNotFoundException" />
		public DescribeLoadBalancerPolicyTypesResponse DescribeLoadBalancerPolicyTypes(DescribeLoadBalancerPolicyTypesRequest request)
		{
			var task = DescribeLoadBalancerPolicyTypesAsync(request);
			try
			{
				return task.Result;
			}
			catch(AggregateException e)
			{
				throw e.InnerException;
			}
		}
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerPolicyTypes operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.DescribeLoadBalancerPolicyTypes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerPolicyTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeLoadBalancerPolicyTypesResponse> DescribeLoadBalancerPolicyTypesAsync(DescribeLoadBalancerPolicyTypesRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new DescribeLoadBalancerPolicyTypesRequestMarshaller();
			var unmarshaller = DescribeLoadBalancerPolicyTypesResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, DescribeLoadBalancerPolicyTypesRequest, DescribeLoadBalancerPolicyTypesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para> Returns meta-information on the specified LoadBalancer policies defined by the Elastic Load Balancing service. The policy types that
        /// are returned from this action can be used in a CreateLoadBalancerPolicy action to instantiate specific policy configurations that will be
        /// applied to an Elastic LoadBalancer. </para>
        /// </summary>
        /// 
        /// <param name="describeLoadBalancerPolicyTypesRequest">Container for the necessary parameters to execute the DescribeLoadBalancerPolicyTypes
        /// service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicyTypes service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.PolicyTypeNotFoundException" />
		public DescribeLoadBalancerPolicyTypesResponse DescribeLoadBalancerPolicyTypes()
		{
			return this.DescribeLoadBalancerPolicyTypes(new DescribeLoadBalancerPolicyTypesRequest());
		}
 
        /// <summary>
        /// <para> Returns detailed configuration information for the specified LoadBalancers. If no LoadBalancers are specified, the operation returns
        /// configuration information for all LoadBalancers created by the caller. </para> <para><b>NOTE:</b> The client must have created the specified
        /// input LoadBalancers in order to retrieve this information; the client must provide the same account credentials as those that were used to
        /// create the LoadBalancer. </para>
        /// </summary>
        /// 
        /// <param name="describeLoadBalancersRequest">Container for the necessary parameters to execute the DescribeLoadBalancers service method on
        /// AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancers service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
		public DescribeLoadBalancersResponse DescribeLoadBalancers(DescribeLoadBalancersRequest request)
		{
			var task = DescribeLoadBalancersAsync(request);
			try
			{
				return task.Result;
			}
			catch(AggregateException e)
			{
				throw e.InnerException;
			}
		}
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancers operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.DescribeLoadBalancers"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeLoadBalancersResponse> DescribeLoadBalancersAsync(DescribeLoadBalancersRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new DescribeLoadBalancersRequestMarshaller();
			var unmarshaller = DescribeLoadBalancersResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, DescribeLoadBalancersRequest, DescribeLoadBalancersResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para> Returns detailed configuration information for the specified LoadBalancers. If no LoadBalancers are specified, the operation returns
        /// configuration information for all LoadBalancers created by the caller. </para> <para><b>NOTE:</b> The client must have created the specified
        /// input LoadBalancers in order to retrieve this information; the client must provide the same account credentials as those that were used to
        /// create the LoadBalancer. </para>
        /// </summary>
        /// 
        /// <param name="describeLoadBalancersRequest">Container for the necessary parameters to execute the DescribeLoadBalancers service method on
        /// AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancers service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
		public DescribeLoadBalancersResponse DescribeLoadBalancers()
		{
			return this.DescribeLoadBalancers(new DescribeLoadBalancersRequest());
		}
 
        /// <summary>
        /// <para> Removes subnets from the set of configured subnets in the VPC for the LoadBalancer. </para> <para> After a subnet is removed all of
        /// the EndPoints registered with the LoadBalancer that are in the removed subnet will go into the <i>OutOfService</i> state. When a subnet is
        /// removed, the LoadBalancer will balance the traffic among the remaining routable subnets for the LoadBalancer. </para>
        /// </summary>
        /// 
        /// <param name="detachLoadBalancerFromSubnetsRequest">Container for the necessary parameters to execute the DetachLoadBalancerFromSubnets
        /// service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DetachLoadBalancerFromSubnets service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
		public DetachLoadBalancerFromSubnetsResponse DetachLoadBalancerFromSubnets(DetachLoadBalancerFromSubnetsRequest request)
		{
			var task = DetachLoadBalancerFromSubnetsAsync(request);
			try
			{
				return task.Result;
			}
			catch(AggregateException e)
			{
				throw e.InnerException;
			}
		}
          
        /// <summary>
        /// Initiates the asynchronous execution of the DetachLoadBalancerFromSubnets operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.DetachLoadBalancerFromSubnets"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachLoadBalancerFromSubnets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DetachLoadBalancerFromSubnetsResponse> DetachLoadBalancerFromSubnetsAsync(DetachLoadBalancerFromSubnetsRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new DetachLoadBalancerFromSubnetsRequestMarshaller();
			var unmarshaller = DetachLoadBalancerFromSubnetsResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, DetachLoadBalancerFromSubnetsRequest, DetachLoadBalancerFromSubnetsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para> Removes the specified EC2 Availability Zones from the set of configured Availability Zones for the LoadBalancer. </para> <para> There
        /// must be at least one Availability Zone registered with a LoadBalancer at all times. A client cannot remove all the Availability Zones from a
        /// LoadBalancer. Once an Availability Zone is removed, all the instances registered with the LoadBalancer that are in the removed Availability
        /// Zone go into the OutOfService state. Upon Availability Zone removal, the LoadBalancer attempts to equally balance the traffic among its
        /// remaining usable Availability Zones. Trying to remove an Availability Zone that was not associated with the LoadBalancer does nothing.
        /// </para> <para><b>NOTE:</b> In order for this call to be successful, the client must have created the LoadBalancer. The client must provide
        /// the same account credentials as those that were used to create the LoadBalancer. </para>
        /// </summary>
        /// 
        /// <param name="disableAvailabilityZonesForLoadBalancerRequest">Container for the necessary parameters to execute the
        /// DisableAvailabilityZonesForLoadBalancer service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DisableAvailabilityZonesForLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
		public DisableAvailabilityZonesForLoadBalancerResponse DisableAvailabilityZonesForLoadBalancer(DisableAvailabilityZonesForLoadBalancerRequest request)
		{
			var task = DisableAvailabilityZonesForLoadBalancerAsync(request);
			try
			{
				return task.Result;
			}
			catch(AggregateException e)
			{
				throw e.InnerException;
			}
		}
          
        /// <summary>
        /// Initiates the asynchronous execution of the DisableAvailabilityZonesForLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.DisableAvailabilityZonesForLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableAvailabilityZonesForLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DisableAvailabilityZonesForLoadBalancerResponse> DisableAvailabilityZonesForLoadBalancerAsync(DisableAvailabilityZonesForLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new DisableAvailabilityZonesForLoadBalancerRequestMarshaller();
			var unmarshaller = DisableAvailabilityZonesForLoadBalancerResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, DisableAvailabilityZonesForLoadBalancerRequest, DisableAvailabilityZonesForLoadBalancerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para> Adds one or more EC2 Availability Zones to the LoadBalancer. </para> <para> The LoadBalancer evenly distributes requests across all
        /// its registered Availability Zones that contain instances. As a result, the client must ensure that its LoadBalancer is appropriately scaled
        /// for each registered Availability Zone. </para> <para><b>NOTE:</b> The new EC2 Availability Zones to be added must be in the same EC2 Region
        /// as the Availability Zones for which the LoadBalancer was created. </para>
        /// </summary>
        /// 
        /// <param name="enableAvailabilityZonesForLoadBalancerRequest">Container for the necessary parameters to execute the
        /// EnableAvailabilityZonesForLoadBalancer service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the EnableAvailabilityZonesForLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
		public EnableAvailabilityZonesForLoadBalancerResponse EnableAvailabilityZonesForLoadBalancer(EnableAvailabilityZonesForLoadBalancerRequest request)
		{
			var task = EnableAvailabilityZonesForLoadBalancerAsync(request);
			try
			{
				return task.Result;
			}
			catch(AggregateException e)
			{
				throw e.InnerException;
			}
		}
          
        /// <summary>
        /// Initiates the asynchronous execution of the EnableAvailabilityZonesForLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.EnableAvailabilityZonesForLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableAvailabilityZonesForLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<EnableAvailabilityZonesForLoadBalancerResponse> EnableAvailabilityZonesForLoadBalancerAsync(EnableAvailabilityZonesForLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new EnableAvailabilityZonesForLoadBalancerRequestMarshaller();
			var unmarshaller = EnableAvailabilityZonesForLoadBalancerResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, EnableAvailabilityZonesForLoadBalancerRequest, EnableAvailabilityZonesForLoadBalancerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para> Adds new instances to the LoadBalancer. </para> <para> Once the instance is registered, it starts receiving traffic and requests from
        /// the LoadBalancer. Any instance that is not in any of the Availability Zones registered for the LoadBalancer will be moved to the
        /// <i>OutOfService</i> state. It will move to the <i>InService</i> state when the Availability Zone is added to the LoadBalancer. </para>
        /// <para><b>NOTE:</b> In order for this call to be successful, the client must have created the LoadBalancer. The client must provide the same
        /// account credentials as those that were used to create the LoadBalancer. </para> <para><b>NOTE:</b> Completion of this API does not guarantee
        /// that operation has completed. Rather, it means that the request has been registered and the changes will happen shortly. </para>
        /// </summary>
        /// 
        /// <param name="registerInstancesWithLoadBalancerRequest">Container for the necessary parameters to execute the
        /// RegisterInstancesWithLoadBalancer service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the RegisterInstancesWithLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidInstanceException" />
		public RegisterInstancesWithLoadBalancerResponse RegisterInstancesWithLoadBalancer(RegisterInstancesWithLoadBalancerRequest request)
		{
			var task = RegisterInstancesWithLoadBalancerAsync(request);
			try
			{
				return task.Result;
			}
			catch(AggregateException e)
			{
				throw e.InnerException;
			}
		}
          
        /// <summary>
        /// Initiates the asynchronous execution of the RegisterInstancesWithLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.RegisterInstancesWithLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterInstancesWithLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<RegisterInstancesWithLoadBalancerResponse> RegisterInstancesWithLoadBalancerAsync(RegisterInstancesWithLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new RegisterInstancesWithLoadBalancerRequestMarshaller();
			var unmarshaller = RegisterInstancesWithLoadBalancerResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, RegisterInstancesWithLoadBalancerRequest, RegisterInstancesWithLoadBalancerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para> Sets the certificate that terminates the specified listener's SSL connections. The specified certificate replaces any prior
        /// certificate that was used on the same LoadBalancer and port. </para> <para>For information on using SetLoadBalancerListenerSSLCertificate,
        /// see <i>Using the Query API </i> in the Updating an SSL Certificate for a Load Balancer section in of the <i>Elastic Load Balancing Developer
        /// Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="setLoadBalancerListenerSSLCertificateRequest">Container for the necessary parameters to execute the
        /// SetLoadBalancerListenerSSLCertificate service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the SetLoadBalancerListenerSSLCertificate service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.CertificateNotFoundException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.ListenerNotFoundException" />
		public SetLoadBalancerListenerSSLCertificateResponse SetLoadBalancerListenerSSLCertificate(SetLoadBalancerListenerSSLCertificateRequest request)
		{
			var task = SetLoadBalancerListenerSSLCertificateAsync(request);
			try
			{
				return task.Result;
			}
			catch(AggregateException e)
			{
				throw e.InnerException;
			}
		}
          
        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerListenerSSLCertificate operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.SetLoadBalancerListenerSSLCertificate"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerListenerSSLCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<SetLoadBalancerListenerSSLCertificateResponse> SetLoadBalancerListenerSSLCertificateAsync(SetLoadBalancerListenerSSLCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new SetLoadBalancerListenerSSLCertificateRequestMarshaller();
			var unmarshaller = SetLoadBalancerListenerSSLCertificateResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, SetLoadBalancerListenerSSLCertificateRequest, SetLoadBalancerListenerSSLCertificateResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para> Replaces the current set of policies associated with a port on which the back-end server is listening with a new set of policies.
        /// After the policies have been created using CreateLoadBalancerPolicy, they can be applied here as a list. At this time, only the back-end
        /// server authentication policy type can be applied to the back-end ports; this policy type is composed of multiple public key policies.
        /// </para>
        /// </summary>
        /// 
        /// <param name="setLoadBalancerPoliciesForBackendServerRequest">Container for the necessary parameters to execute the
        /// SetLoadBalancerPoliciesForBackendServer service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the SetLoadBalancerPoliciesForBackendServer service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.PolicyNotFoundException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
		public SetLoadBalancerPoliciesForBackendServerResponse SetLoadBalancerPoliciesForBackendServer(SetLoadBalancerPoliciesForBackendServerRequest request)
		{
			var task = SetLoadBalancerPoliciesForBackendServerAsync(request);
			try
			{
				return task.Result;
			}
			catch(AggregateException e)
			{
				throw e.InnerException;
			}
		}
          
        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerPoliciesForBackendServer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.SetLoadBalancerPoliciesForBackendServer"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerPoliciesForBackendServer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<SetLoadBalancerPoliciesForBackendServerResponse> SetLoadBalancerPoliciesForBackendServerAsync(SetLoadBalancerPoliciesForBackendServerRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new SetLoadBalancerPoliciesForBackendServerRequestMarshaller();
			var unmarshaller = SetLoadBalancerPoliciesForBackendServerResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, SetLoadBalancerPoliciesForBackendServerRequest, SetLoadBalancerPoliciesForBackendServerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
 
        /// <summary>
        /// <para> Associates, updates, or disables a policy with a listener on the LoadBalancer. You can associate multiple policies with a listener.
        /// </para>
        /// </summary>
        /// 
        /// <param name="setLoadBalancerPoliciesOfListenerRequest">Container for the necessary parameters to execute the
        /// SetLoadBalancerPoliciesOfListener service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the SetLoadBalancerPoliciesOfListener service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.PolicyNotFoundException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.ListenerNotFoundException" />
		public SetLoadBalancerPoliciesOfListenerResponse SetLoadBalancerPoliciesOfListener(SetLoadBalancerPoliciesOfListenerRequest request)
		{
			var task = SetLoadBalancerPoliciesOfListenerAsync(request);
			try
			{
				return task.Result;
			}
			catch(AggregateException e)
			{
				throw e.InnerException;
			}
		}
          
        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerPoliciesOfListener operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.SetLoadBalancerPoliciesOfListener"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerPoliciesOfListener operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<SetLoadBalancerPoliciesOfListenerResponse> SetLoadBalancerPoliciesOfListenerAsync(SetLoadBalancerPoliciesOfListenerRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			var marshaller = new SetLoadBalancerPoliciesOfListenerRequestMarshaller();
			var unmarshaller = SetLoadBalancerPoliciesOfListenerResponseUnmarshaller.GetInstance();
			var response = await Invoke<IRequest, SetLoadBalancerPoliciesOfListenerRequest, SetLoadBalancerPoliciesOfListenerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
			return response;
		}
	}
}
