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
using System.Collections.Generic;

using Amazon.SimpleNotificationService.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SimpleNotificationService.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   SubscribeResult Unmarshaller
     /// </summary>
    internal class SubscribeResultUnmarshaller : IUnmarshaller<SubscribeResult, XmlUnmarshallerContext>, IUnmarshaller<SubscribeResult, JsonUnmarshallerContext> 
    {
        public SubscribeResult Unmarshall(XmlUnmarshallerContext context) 
        {
            SubscribeResult subscribeResult = new SubscribeResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("SubscriptionArn", targetDepth))
                    {
                        subscribeResult.SubscriptionArn = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return subscribeResult;
                }
            }
                        


            return subscribeResult;
        }

        public SubscribeResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static SubscribeResultUnmarshaller instance;

        public static SubscribeResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new SubscribeResultUnmarshaller();

            return instance;
        }
    }
}
    
