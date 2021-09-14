/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.DatascienceService.Models;
using Oci.DatascienceService.Requests;
using Oci.DatascienceService.Responses;

namespace Oci.DatascienceService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of DataScience.
    /// </summary>
    public class DataScienceWaiters
    {
        private readonly DataScienceClient client;

        public  DataScienceWaiters(DataScienceClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetJobRequest, GetJobResponse> ForJob(GetJobRequest request, params JobLifecycleState[] targetStates)
        {
            return this.ForJob(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetJobRequest, GetJobResponse> ForJob(GetJobRequest request, WaiterConfiguration config, params JobLifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetJobRequest, GetJobResponse>(
                request,
                request => client.GetJob(request),
                response => targetStates.Contains(response.Job.LifecycleState.Value),
                targetStates.Contains(JobLifecycleState.Deleted)
            );
            return new Waiter<GetJobRequest, GetJobResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetJobRunRequest, GetJobRunResponse> ForJobRun(GetJobRunRequest request, params JobRunLifecycleState[] targetStates)
        {
            return this.ForJobRun(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetJobRunRequest, GetJobRunResponse> ForJobRun(GetJobRunRequest request, WaiterConfiguration config, params JobRunLifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetJobRunRequest, GetJobRunResponse>(
                request,
                request => client.GetJobRun(request),
                response => targetStates.Contains(response.JobRun.LifecycleState.Value),
                targetStates.Contains(JobRunLifecycleState.Deleted)
            );
            return new Waiter<GetJobRunRequest, GetJobRunResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetModelRequest, GetModelResponse> ForModel(GetModelRequest request, params ModelLifecycleState[] targetStates)
        {
            return this.ForModel(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetModelRequest, GetModelResponse> ForModel(GetModelRequest request, WaiterConfiguration config, params ModelLifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetModelRequest, GetModelResponse>(
                request,
                request => client.GetModel(request),
                response => targetStates.Contains(response.Model.LifecycleState.Value),
                targetStates.Contains(ModelLifecycleState.Deleted)
            );
            return new Waiter<GetModelRequest, GetModelResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetModelDeploymentRequest, GetModelDeploymentResponse> ForModelDeployment(GetModelDeploymentRequest request, params ModelDeploymentLifecycleState[] targetStates)
        {
            return this.ForModelDeployment(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetModelDeploymentRequest, GetModelDeploymentResponse> ForModelDeployment(GetModelDeploymentRequest request, WaiterConfiguration config, params ModelDeploymentLifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetModelDeploymentRequest, GetModelDeploymentResponse>(
                request,
                request => client.GetModelDeployment(request),
                response => targetStates.Contains(response.ModelDeployment.LifecycleState.Value),
                targetStates.Contains(ModelDeploymentLifecycleState.Deleted)
            );
            return new Waiter<GetModelDeploymentRequest, GetModelDeploymentResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetNotebookSessionRequest, GetNotebookSessionResponse> ForNotebookSession(GetNotebookSessionRequest request, params NotebookSessionLifecycleState[] targetStates)
        {
            return this.ForNotebookSession(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetNotebookSessionRequest, GetNotebookSessionResponse> ForNotebookSession(GetNotebookSessionRequest request, WaiterConfiguration config, params NotebookSessionLifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetNotebookSessionRequest, GetNotebookSessionResponse>(
                request,
                request => client.GetNotebookSession(request),
                response => targetStates.Contains(response.NotebookSession.LifecycleState.Value),
                targetStates.Contains(NotebookSessionLifecycleState.Deleted)
            );
            return new Waiter<GetNotebookSessionRequest, GetNotebookSessionResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetProjectRequest, GetProjectResponse> ForProject(GetProjectRequest request, params ProjectLifecycleState[] targetStates)
        {
            return this.ForProject(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetProjectRequest, GetProjectResponse> ForProject(GetProjectRequest request, WaiterConfiguration config, params ProjectLifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetProjectRequest, GetProjectResponse>(
                request,
                request => client.GetProject(request),
                response => targetStates.Contains(response.Project.LifecycleState.Value),
                targetStates.Contains(ProjectLifecycleState.Deleted)
            );
            return new Waiter<GetProjectRequest, GetProjectResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetWorkRequestRequest, GetWorkRequestResponse> ForWorkRequest(GetWorkRequestRequest request, params WorkRequestStatus[] targetStates)
        {
            return this.ForWorkRequest(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetWorkRequestRequest, GetWorkRequestResponse> ForWorkRequest(GetWorkRequestRequest request, WaiterConfiguration config, params WorkRequestStatus[] targetStates)
        {
            var agent = new WaiterAgent<GetWorkRequestRequest, GetWorkRequestResponse>(
                request,
                request => client.GetWorkRequest(request),
                response => targetStates.Contains(response.WorkRequest.Status.Value)
            );
            return new Waiter<GetWorkRequestRequest, GetWorkRequestResponse>(config, agent);
        }
    }
}
