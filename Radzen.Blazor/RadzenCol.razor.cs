using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Radzen.Blazor
{
    /// <summary>
    /// RadzenCard component.
    /// </summary>
    public partial class RadzenCol : RadzenRowCol
    {
        /// <summary>
        /// Gets or sets the XS size.
        /// </summary>
        /// <value>The XS size.</value>
        [Parameter]
        public int SizeXS { get; set; }

        /// <summary>
        /// Gets or sets the SM size.
        /// </summary>
        /// <value>The SM size.</value>
        [Parameter]
        public int SizeSM { get; set; }

        /// <summary>
        /// Gets or sets the MD size.
        /// </summary>
        /// <value>The MD size.</value>
        [Parameter]
        public int SizeMD { get; set; }

        /// <summary>
        /// Gets or sets the LG size.
        /// </summary>
        /// <value>The LG size.</value>
        [Parameter]
        public int SizeLG { get; set; }

        /// <summary>
        /// Gets or sets the XL size.
        /// </summary>
        /// <value>The XL size.</value>
        [Parameter]
        public int SizeXL { get; set; }

        /// <summary>
        /// Gets or sets the XS offset.
        /// </summary>
        /// <value>The XS offset.</value>
        [Parameter]
        public int OffsetXS { get; set; }

        /// <summary>
        /// Gets or sets the SM offset.
        /// </summary>
        /// <value>The SM offset.</value>
        [Parameter]
        public int OffsetSM { get; set; }

        /// <summary>
        /// Gets or sets the MD offset.
        /// </summary>
        /// <value>The MD offset.</value>
        [Parameter]
        public int OffsetMD { get; set; }

        /// <summary>
        /// Gets or sets the LG offset.
        /// </summary>
        /// <value>The LG offset.</value>
        [Parameter]
        public int OffsetLG { get; set; }

        /// <summary>
        /// Gets or sets the XL offset.
        /// </summary>
        /// <value>The XL offset.</value>
        [Parameter]
        public int OffsetXL { get; set; }

        /// <summary>
        /// Gets or sets the XS order.
        /// </summary>
        /// <value>The XS order.</value>
        [Parameter]
        public int OrderXS { get; set; }

        /// <summary>
        /// Gets or sets the SM order.
        /// </summary>
        /// <value>The SM order.</value>
        [Parameter]
        public int OrderSM { get; set; }

        /// <summary>
        /// Gets or sets the MD order.
        /// </summary>
        /// <value>The MD order.</value>
        [Parameter]
        public int OrderMD { get; set; }

        /// <summary>
        /// Gets or sets the LG order.
        /// </summary>
        /// <value>The LG order.</value>
        [Parameter]
        public int OrderLG { get; set; }

        /// <summary>
        /// Gets or sets the XL order.
        /// </summary>
        /// <value>The XL order.</value>
        [Parameter]
        public int OrderXL { get; set; }

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
            return $"{Style}{(!string.IsNullOrEmpty(Style) && !Style.EndsWith(";") ? ";" : "")}";
        }

        /// <inheritdoc />
        protected override string GetComponentCssClass()
        {
            var list = new List<string>();

            // Size
            if (SizeXS != 0)
            {
                list.Add($"rz-col-xs-{SizeXS}");
            }

            if (SizeSM != 0)
            {
                list.Add($"rz-col-sm-{SizeSM}");
            }

            if (SizeMD != 0)
            {
                list.Add($"rz-col-md-{SizeMD}");
            }

            if (SizeLG != 0)
            {
                list.Add($"rz-col-lg-{SizeLG}");
            }

            if (SizeXL != 0)
            {
                list.Add($"rz-col-xl-{SizeXL}");
            }

            // Ofsset
            if (OffsetXS != 0)
            {
                list.Add($"rz-col-offset-xs-{OffsetXS}");
            }

            if (OffsetSM != 0)
            {
                list.Add($"rz-col-offset-sm-{OffsetSM}");
            }

            if (OffsetMD != 0)
            {
                list.Add($"rz-col-offset-md-{OffsetMD}");
            }

            if (OffsetLG != 0)
            {
                list.Add($"rz-col-offset-lg-{OffsetLG}");
            }

            if (OffsetXL != 0)
            {
                list.Add($"rz-col-offset-xl-{OffsetXL}");
            }

            // Order
            if (OrderXS != 0)
            {
                list.Add($"rz-col-order-xs-{OrderXS}");
            }

            if (OrderSM != 0)
            {
                list.Add($"rz-col-order-sm-{OrderSM}");
            }

            if (OrderMD != 0)
            {
                list.Add($"rz-col-order-md-{OrderMD}");
            }

            if (OrderLG != 0)
            {
                list.Add($"rz-col-order-lg-{OrderLG}");
            }

            if (OrderXL != 0)
            {
                list.Add($"rz-col-order-xl-{OrderXL}");
            }

            return string.Join(" ", list);
        }
    }
}
