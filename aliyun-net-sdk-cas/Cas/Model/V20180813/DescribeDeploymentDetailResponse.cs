/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.cas.Model.V20180813
{
	public class DescribeDeploymentDetailResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDeploymentDetail_Deployment> deploymentDetail;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public List<DescribeDeploymentDetail_Deployment> DeploymentDetail
		{
			get
			{
				return deploymentDetail;
			}
			set	
			{
				deploymentDetail = value;
			}
		}

		public class DescribeDeploymentDetail_Deployment
		{

			private string cloudProduct;

			private string domain;

			private string region;

			private long? deployTime;

			private long? id;

			public string CloudProduct
			{
				get
				{
					return cloudProduct;
				}
				set	
				{
					cloudProduct = value;
				}
			}

			public string Domain
			{
				get
				{
					return domain;
				}
				set	
				{
					domain = value;
				}
			}

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public long? DeployTime
			{
				get
				{
					return deployTime;
				}
				set	
				{
					deployTime = value;
				}
			}

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}
		}
	}
}
