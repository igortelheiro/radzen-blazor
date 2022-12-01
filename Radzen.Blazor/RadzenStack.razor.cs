﻿using Microsoft.AspNetCore.Components;
using System;
using System.Linq;

namespace Radzen.Blazor
{
    /// <summary>
    /// RadzenCard component.
    /// </summary>
    public partial class RadzenStack : RadzenComponentWithChildren
    {
        /// <summary>
        /// Gets or sets the orientation.
        /// </summary>
        /// <value>The orientation.</value>
        [Parameter]
        public Orientation Orientation { get; set; } = Orientation.Vertical;

        /// <summary>
        /// Gets or sets the spacing
        /// </summary>
        /// <value>The spacing.</value>
        [Parameter]
        public string Spacing { get; set; }

        /// <summary>
        /// Gets the final CSS style rendered by the component. Combines it with a <c>style</c> custom attribute.
        /// </summary>
        protected string GetStyle()
        {
            if (Attributes != null && Attributes.TryGetValue("style", out var style) && !string.IsNullOrEmpty(Convert.ToString(@style)))
            {
                return $"{GetComponentStyle()} {@style}";
            }

            return GetComponentStyle();
        }

        /// <summary>
        /// Gets the component CSS style.
        /// </summary>
        protected string GetComponentStyle()
        {
            return $"{(!string.IsNullOrEmpty(Spacing) ? "gap:" + Spacing + (Spacing.All(c => Char.IsDigit(c)) ? "px;" : "") : "")}";
        }

        /// <inheritdoc />
        protected override string GetComponentCssClass()
        {
            var horizontal = Orientation == Orientation.Horizontal;

            return $"rz-display-flex rz-flex-{(horizontal ? "column" : "row")} rz-align-items-center rz-justify-content-center";
        }
    }
}
