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
    using Amazon.OpsWorks.Model;
    using Amazon.Runtime;
    using Amazon.Runtime.Internal;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// Response Unmarshaller for CreateApp operation
      /// </summary>
      internal class CreateAppResponseUnmarshaller : JsonResponseUnmarshaller
      {
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
          CreateAppResponse response = new CreateAppResponse();          
          
          context.Read();
          
          UnmarshallResult(context,response);
          return response;
        }
        
        private void UnmarshallResult(JsonUnmarshallerContext context,CreateAppResponse response)
        {
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("AppId", targetDepth))
              {
                response.AppId = StringUnmarshaller.GetInstance().Unmarshall(context);
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
          
          if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
          {
            return new ResourceNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
          {
            return new ValidationException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          return new AmazonOpsWorksException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static CreateAppResponseUnmarshaller instance;
        public static CreateAppResponseUnmarshaller GetInstance()
        {
          if (instance == null)
          {
            instance = new CreateAppResponseUnmarshaller();
          }
          return instance;
        }
  
      }
    }
  
