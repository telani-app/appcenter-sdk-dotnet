// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;

namespace Microsoft.AppCenter.Distribute
{
    /// <summary>
    /// Distribute feature.
    /// </summary>
    public static partial class Distribute
    {
        /// <summary>
        /// Check whether the Distribute service is enabled or not.
        /// </summary>
        /// <returns>A task with result being true if enabled, false if disabled.</returns>
        public static Task<bool> IsEnabledAsync()
        {
            return PlatformIsEnabledAsync();
        }

        /// <summary>
        /// Enable or disable the Distribute service.
        /// </summary>
        /// <returns>A task to monitor the operation.</returns>
        public static Task SetEnabledAsync(bool enabled)
        {
            return PlatformSetEnabledAsync(enabled);
        }

        /// <summary>
        /// Change the base URL opened in the browser to get update token from user login information.
        /// </summary>
        /// <param name="installUrl">Install base URL.</param>
        public static void SetInstallUrl(string installUrl)
        {
            PlatformSetInstallUrl(installUrl);
        }

        /// <summary>
        /// Change the base URL used to make API calls.
        /// </summary>
        /// <param name="apiUrl">API base URL.</param>
        public static void SetApiUrl(string apiUrl)
        {
            PlatformSetApiUrl(apiUrl);
        }

        /// <summary>
        /// Sets the release available callback.
        /// </summary>
        /// <value>The release available callback.</value>
        public static ReleaseAvailableCallback ReleaseAvailable
        {
            set
            {
                SetReleaseAvailableCallback(value);
            }
        }

        /// <summary>
        /// Sets the app will close callback.
        /// </summary>
        /// <value>The app will close callback.</value>
        public static WillExitAppCallback WillExitApp
        {
            set
            {
                SetWillExitAppCallback(value);
            }
        }

        /// <summary>
        /// Sets the no release available callback.
        /// </summary>
        /// <value>The no release available callback.</value>
        public static NoReleaseAvailableCallback NoReleaseAvailable
        {
            set
            {
                SetNoReleaseAvailable(value);
            }
        }

        /// <summary>
        /// If update dialog is customized by returning <c>true</c> in <see cref="ReleaseAvailableCallback"/>,
        /// You need to tell the distribute SDK using this function what is the user action.
        /// </summary>
        /// <param name="updateAction">Update action. On mandatory update, you can only pass <see cref="UpdateAction.Update"/></param>
        public static void NotifyUpdateAction(UpdateAction updateAction)
        {
            HandleUpdateAction(updateAction);
        }

        /// <summary>
        /// Sets the update track (public vs private).
        /// </summary>
        /// <value>UpdateTrack update track.</value>
        public static UpdateTrack UpdateTrack
        {
            get
            {
                return GetUpdateTrack();
            }
            set
            {
                SetUpdateTrack(value);
            }
        }

        /// <summary>
        ///  Check for the latest release using the selected update track.
        /// </summary>
        public static void CheckForUpdate()
        {
            PlatformCheckForUpdate();
        }

        /// <summary>
        /// Disable automatic check for update before the service starts.
        /// </summary>
        public static void DisableAutomaticCheckForUpdate()
        {
            PlatformDisableAutomaticCheckForUpdate();
        }

        internal static void UnsetInstance()
        {
            PlatformUnsetInstance();
        }
    }
}
