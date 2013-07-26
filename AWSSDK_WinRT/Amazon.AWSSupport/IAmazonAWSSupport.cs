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

using Amazon.AWSSupport.Model;

namespace Amazon.AWSSupport
{
    /// <summary>
    /// Interface for accessing AmazonAWSSupport.
    /// 
    /// AWS Support <para>The AWS Support API reference is intended for programmers who need detailed information about the AWS Support actions and
    /// data types. This service enables you to manage with your AWS Support cases programmatically. It is built on the AWS Query API programming
    /// model and provides HTTP methods that take parameters and return results in JSON format.</para> <para>The AWS Support service also exposes a
    /// set of Trusted Advisor features. You can retrieve a list of checks you can run on your resources, specify checks to run and refresh, and
    /// check the status of checks you have submitted. </para> <para>The following list describes the AWS Support case management actions: </para>
    /// <ul>
    /// <li> <b>Service names, issue categories, and available severity levels. </b> The actions DescribeServices and DescribeSeverityLevels enable
    /// you to obtain AWS service names, service codes, service categories, and problem severity levels. You use these values when you call the
    /// CreateCase action. </li>
    /// <li> <b>Case Creation, case details, and case resolution</b> . The actions CreateCase, DescribeCases, and ResolveCase enable you to create
    /// AWS Support cases, retrieve them, and resolve them.</li>
    /// <li> <b>Case communication</b> . The actions DescribeCaseCommunications and AddCommunicationToCase enable you to retrieve and add
    /// communication to AWS Support cases. </li>
    /// 
    /// </ul>
    /// <para>The following list describes the actions available from the AWS Support service for Trusted Advisor:</para>
    /// <ul>
    /// <li> DescribeTrustedAdviserChecks </li>
    /// returns the list of checks that you can run against your AWS resources. <li>Using the CheckId for a specific check returned by
    /// DescribeTrustedAdviserChecks, you can call DescribeTrustedAdvisorCheckResult </li>
    /// and obtain a new result for the check you specified. <li> Using DescribeTrustedAdvisorCheckSummaries, you can get summaries for a set of
    /// Trusted Advisor checks.</li>
    /// <li> RefreshTrustedAdvisorCheck enables you to request that Trusted Advisor run the check again. </li>
    /// <li> gets statuses on the checks you are running. </li>
    /// 
    /// </ul>
    /// <para>For authentication of requests, the AWS Support uses Signature Version 4 Signing Process.</para> <para>See the AWS Support Developer
    /// Guide for information about how to use this service to manage create and manage your support cases, and how to call Trusted Advisor for
    /// results of checks on your resources. </para>
    /// </summary>
	public partial interface IAmazonAWSSupport : IDisposable
	{
 
        /// <summary>
        /// <para>This action adds additional customer communication to an AWS Support case. You use the <i>CaseId</i> value to identify the case to
        /// which you want to add communication. You can list a set of email addresses to copy on the communication using the <i>CcEmailAddresses</i>
        /// value. The <i>CommunicationBody</i> value contains the text of the communication.</para> <para>This action's response indicates the success
        /// or failure of the request.</para> <para>This action implements a subset of the behavior on the AWS Support Your Support Cases web
        /// form.</para>
        /// </summary>
        /// 
        /// <param name="addCommunicationToCaseRequest">Container for the necessary parameters to execute the AddCommunicationToCase service method on
        /// AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the AddCommunicationToCase service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="T:Amazon.AWSSupport.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.AWSSupport.Model.CaseIdNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<AddCommunicationToCaseResponse> AddCommunicationToCaseAsync(AddCommunicationToCaseRequest addCommunicationToCaseRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Creates a new case in the AWS Support Center. This action is modeled on the behavior of the AWS Support Center Open a new case page.
        /// Its parameters require you to specify the following information: </para> <ol> <li> <b>ServiceCode.</b> Represents a code for an AWS service.
        /// You obtain the <i>ServiceCode</i> by calling DescribeServices. </li>
        /// <li> <b>CategoryCode</b> . Represents a category for the service defined for the ServiceCode value. You also obtain the cateogory code for
        /// a service by calling DescribeServices. Each AWS service defines its own set of category codes. </li>
        /// <li> <b>SeverityCode</b> . Represents a value that specifies the urgency of the case, and the time interval in which your service level
        /// agreement specifies a response from AWS Support. You obtain the SeverityCode by calling DescribeSeverityLevels.</li>
        /// <li> <b>Subject</b> . Represents the <b>Subject</b> field on the AWS Support Center Open a new case page.</li>
        /// <li> <b>CommunicationBody</b> . Represents the <b>Description</b> field on the AWS Support Center Open a new case page.</li>
        /// <li> <b>Language</b> . Specifies the human language in which AWS Support handles the case. The API currently supports English and
        /// Japanese.</li>
        /// <li> <b>CcEmailAddresses</b> . Represents the AWS Support Center <b>CC</b> field on the Open a new case page. You can list email
        /// addresses to be copied on any correspondence about the case. The account that opens the case is already identified by passing the AWS
        /// Credentials in the HTTP POST method or in a method or function call from one of the programming languages supported by an AWS SDK. </li>
        /// </ol> <para><b>NOTE:</b>The AWS Support API does not currently support the ability to add attachments to cases. You can, however, call
        /// AddCommunicationToCase to add information to an open case. </para> <para>A successful CreateCase request returns an AWS Support case number.
        /// Case numbers are used by DescribeCases request to retrieve existing AWS Support support cases. </para>
        /// </summary>
        /// 
        /// <param name="createCaseRequest">Container for the necessary parameters to execute the CreateCase service method on AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the CreateCase service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="T:Amazon.AWSSupport.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.AWSSupport.Model.CaseCreationLimitExceededException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateCaseResponse> CreateCaseAsync(CreateCaseRequest createCaseRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>This action returns a list of cases that you specify by passing one or more CaseIds. In addition, you can filter the cases by date by
        /// setting values for the AfterTime and BeforeTime request parameters. </para> <para> The response returns the following in JSON format:
        /// </para> <ol> <li>One or more CaseDetails data types. </li>
        /// <li>One or more <i>NextToken</i> objects, strings that specifies where to paginate the returned records represented by <i>CaseDetails</i>
        /// .</li>
        /// </ol>
        /// </summary>
        /// 
        /// <param name="describeCasesRequest">Container for the necessary parameters to execute the DescribeCases service method on
        /// AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the DescribeCases service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="T:Amazon.AWSSupport.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.AWSSupport.Model.CaseIdNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeCasesResponse> DescribeCasesAsync(DescribeCasesRequest describeCasesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>This action returns communications regarding the support case. You can use the <i>AfterTime</i> and <i>BeforeTime</i> parameters to
        /// filter by date. The <i>CaseId</i> parameter enables you to identify a specific case by its <i>CaseId</i> number.</para> <para>The
        /// <i>MaxResults</i> and <i>NextToken</i> parameters enable you to control the pagination of the result set. Set <i>MaxResults</i> to the
        /// number of cases you want displayed on each page, and use <i>NextToken</i> to specify the resumption of pagination.</para>
        /// </summary>
        /// 
        /// <param name="describeCommunicationsRequest">Container for the necessary parameters to execute the DescribeCommunications service method on
        /// AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the DescribeCommunications service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="T:Amazon.AWSSupport.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.AWSSupport.Model.CaseIdNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeCommunicationsResponse> DescribeCommunicationsAsync(DescribeCommunicationsRequest describeCommunicationsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns the current list of AWS services and a list of service categories that applies to each one. You then use service names and
        /// categories in your CreateCase requests. Each AWS service has its own set of categories.</para> <para>The service codes and category codes
        /// correspond to the values that are displayed in the <b>Service</b> and <b>Category</b> drop-down lists on the AWS Support Center Open a new
        /// case page. The values in those fields, however, do not necessarily match the service codes and categories returned by the
        /// <c>DescribeServices</c> request. Always use the service codes and categories obtained programmatically. This practice ensures that you
        /// always have the most recent set of service and category codes.</para>
        /// </summary>
        /// 
        /// <param name="describeServicesRequest">Container for the necessary parameters to execute the DescribeServices service method on
        /// AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the DescribeServices service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="T:Amazon.AWSSupport.Model.InternalServerErrorException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeServicesResponse> DescribeServicesAsync(DescribeServicesRequest describeServicesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>This action returns the list of severity levels that you can assign to an AWS Support case. The severity level for a case is also a
        /// field in the CaseDetails data type included in any CreateCase request. </para>
        /// </summary>
        /// 
        /// <param name="describeSeverityLevelsRequest">Container for the necessary parameters to execute the DescribeSeverityLevels service method on
        /// AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the DescribeSeverityLevels service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="T:Amazon.AWSSupport.Model.InternalServerErrorException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeSeverityLevelsResponse> DescribeSeverityLevelsAsync(DescribeSeverityLevelsRequest describeSeverityLevelsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns the status of all refresh requests Trusted Advisor checks called using RefreshTrustedAdvisorCheck. </para>
        /// </summary>
        /// 
        /// <param name="describeTrustedAdvisorCheckRefreshStatusesRequest">Container for the necessary parameters to execute the
        /// DescribeTrustedAdvisorCheckRefreshStatuses service method on AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the DescribeTrustedAdvisorCheckRefreshStatuses service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="T:Amazon.AWSSupport.Model.InternalServerErrorException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeTrustedAdvisorCheckRefreshStatusesResponse> DescribeTrustedAdvisorCheckRefreshStatusesAsync(DescribeTrustedAdvisorCheckRefreshStatusesRequest describeTrustedAdvisorCheckRefreshStatusesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>This action responds with the results of a Trusted Advisor check. Once you have obtained the list of available Trusted Advisor checks
        /// by calling DescribeTrustedAdvisorChecks, you specify the <i>CheckId</i> for the check you want to retrieve from AWS Support.</para>
        /// <para>The response for this action contains a JSON-formatted TrustedAdvisorCheckResult object</para> <para>, which is a container for the
        /// following three objects:</para> <ol> <li> TrustedAdvisorCategorySpecificSummary </li>
        /// <li> TrustedAdvisorResourceDetail </li>
        /// <li> TrustedAdvisorResourcesSummary </li>
        /// </ol> <para>In addition, the response contains the following fields:</para> <ol> <li> <b>Status</b> . Overall status of the check.</li>
        /// <li> <b>Timestamp</b> . Time at which Trusted Advisor last ran the check. </li>
        /// <li> <b>CheckId</b> . Unique identifier for the specific check returned by the request.</li>
        /// </ol>
        /// </summary>
        /// 
        /// <param name="describeTrustedAdvisorCheckResultRequest">Container for the necessary parameters to execute the
        /// DescribeTrustedAdvisorCheckResult service method on AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the DescribeTrustedAdvisorCheckResult service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="T:Amazon.AWSSupport.Model.InternalServerErrorException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeTrustedAdvisorCheckResultResponse> DescribeTrustedAdvisorCheckResultAsync(DescribeTrustedAdvisorCheckResultRequest describeTrustedAdvisorCheckResultRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>This action enables you to get a list of the available Trusted Advisor checks. You must specify a language code. English ("en") and
        /// Japanese ("jp") are currently supported. The response contains a list of TrustedAdvisorCheckDescription objects. </para>
        /// </summary>
        /// 
        /// <param name="describeTrustedAdvisorChecksRequest">Container for the necessary parameters to execute the DescribeTrustedAdvisorChecks service
        /// method on AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the DescribeTrustedAdvisorChecks service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="T:Amazon.AWSSupport.Model.InternalServerErrorException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeTrustedAdvisorChecksResponse> DescribeTrustedAdvisorChecksAsync(DescribeTrustedAdvisorChecksRequest describeTrustedAdvisorChecksRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>This action enables you to get the latest summaries for Trusted Advisor checks that you specify in your request. You submit the list
        /// of Trusted Advisor checks for which you want summaries. You obtain these <i>CheckIds</i> by submitting a DescribeTrustedAdvisorChecks
        /// request. </para> <para>The response body contains an array of TrustedAdvisorCheckSummary objects. </para>
        /// </summary>
        /// 
        /// <param name="describeTrustedAdvisorCheckSummariesRequest">Container for the necessary parameters to execute the
        /// DescribeTrustedAdvisorCheckSummaries service method on AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the DescribeTrustedAdvisorCheckSummaries service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="T:Amazon.AWSSupport.Model.InternalServerErrorException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeTrustedAdvisorCheckSummariesResponse> DescribeTrustedAdvisorCheckSummariesAsync(DescribeTrustedAdvisorCheckSummariesRequest describeTrustedAdvisorCheckSummariesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>This action enables you to query the service to request a refresh for a specific Trusted Advisor check. Your request body contains a
        /// <i>CheckId</i> for which you are querying. The response body contains a RefreshTrustedAdvisorCheckResult object containing <i>Status</i> and
        /// <i>TimeUntilNextRefresh</i> fields.</para>
        /// </summary>
        /// 
        /// <param name="refreshTrustedAdvisorCheckRequest">Container for the necessary parameters to execute the RefreshTrustedAdvisorCheck service
        /// method on AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the RefreshTrustedAdvisorCheck service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="T:Amazon.AWSSupport.Model.InternalServerErrorException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<RefreshTrustedAdvisorCheckResponse> RefreshTrustedAdvisorCheckAsync(RefreshTrustedAdvisorCheckRequest refreshTrustedAdvisorCheckRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Takes a <i>CaseId</i> and returns the initial state of the case along with the state of the case after the call to ResolveCase
        /// completed.</para>
        /// </summary>
        /// 
        /// <param name="resolveCaseRequest">Container for the necessary parameters to execute the ResolveCase service method on
        /// AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the ResolveCase service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="T:Amazon.AWSSupport.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.AWSSupport.Model.CaseIdNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ResolveCaseResponse> ResolveCaseAsync(ResolveCaseRequest resolveCaseRequest, CancellationToken cancellationToken = default(CancellationToken));
	}
}
