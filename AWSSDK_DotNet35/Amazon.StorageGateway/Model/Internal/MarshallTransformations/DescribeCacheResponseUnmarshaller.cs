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
    using System.Net;
    using System.Collections.Generic;
    using Amazon.StorageGateway.Model;
    using Amazon.Runtime;
    using Amazon.Runtime.Internal;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// Response Unmarshaller for DescribeCache operation
      /// </summary>
      internal class DescribeCacheResponseUnmarshaller : JsonResponseUnmarshaller
      {
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
          DescribeCacheResponse response = new DescribeCacheResponse();          
          
          context.Read();
          
          UnmarshallResult(context,response);
          return response;
        }
        
        private void UnmarshallResult(JsonUnmarshallerContext context,DescribeCacheResponse response)
        {
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("GatewayARN", targetDepth))
              {
                response.GatewayARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("DiskIds", targetDepth))
              {
                response.DiskIds = new List<String>();
                        StringUnmarshaller unmarshaller = StringUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     response.DiskIds.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
              if (context.TestExpression("CacheAllocatedInBytes", targetDepth))
              {
                response.CacheAllocatedInBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CacheUsedPercentage", targetDepth))
              {
                response.CacheUsedPercentage = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CacheDirtyPercentage", targetDepth))
              {
                response.CacheDirtyPercentage = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CacheHitPercentage", targetDepth))
              {
                response.CacheHitPercentage = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CacheMissPercentage", targetDepth))
              {
                response.CacheMissPercentage = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {                   
                    return;
                }
            }
                        
            return;
        }                        
        
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
          ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);                    
          
          if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerErrorException"))
          {
            return new InternalServerErrorException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidGatewayRequestException"))
          {
            return new InvalidGatewayRequestException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          return new AmazonStorageGatewayException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static DescribeCacheResponseUnmarshaller instance;
        public static DescribeCacheResponseUnmarshaller GetInstance()
        {
          if (instance == null)
          {
            instance = new DescribeCacheResponseUnmarshaller();
          }
          return instance;
        }
  
      }
    }
  
