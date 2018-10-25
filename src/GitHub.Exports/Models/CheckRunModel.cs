﻿using System;
using System.Collections.Generic;

namespace GitHub.Models
{
    /// <summary>
    /// Model for a single check run.
    /// </summary>
    public class CheckRunModel
    {
        /// <summary>The conclusion of the check run.</summary>
        public CheckConclusionState? Conclusion { get; set; }

        /// <summary>
        /// The current status of a Check Run.
        /// </summary>
        public CheckStatusState Status { get; set; }

        /// <summary>
        /// Identifies the date and time when the check run was started.
        /// </summary>
        public DateTimeOffset? StartedAt { get; set; }

        /// <summary>
        /// Identifies the date and time when the check run was completed.
        /// </summary>
        public DateTimeOffset? CompletedAt { get; set; }

        /// <summary>The name of the check for this check run.</summary>
        public string Name { get; set; }

        /// <summary>
        /// The URL from which to find full details of the check run on the integrator's site.
        /// </summary>
        public string DetailsUrl { get; set; }

        /// <summary>
        /// The title of a Check Run.
        /// </summary>
        public string Title { get; set; }
    }
}