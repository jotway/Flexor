﻿// <copyright file="ItemAlignment.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    /// <summary>
    /// Defines how flex-items are laid out along the flex-container's cross axis.
    /// </summary>
    public static class ItemAlignment
    {
        /// <summary>
        /// Items are aligned along the start of the flex-container's cross axis.
        /// Items are rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IFluentAlignItems Start => new FluentAlignItems(ItemAlignmentOption.Start);

        /// <summary>
        /// Items are aligned along the center of the flex-container's cross axis.
        /// Items are rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IFluentAlignItems Center => new FluentAlignItems(ItemAlignmentOption.Center);

        /// <summary>
        /// Items are aligned along the end of the flex-container's cross axis.
        /// Items are rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IFluentAlignItems End => new FluentAlignItems(ItemAlignmentOption.End);

        /// <summary>
        /// Items are stretched along the entirety of the flex-container's cross axis.
        /// Items are rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IFluentAlignItems Stretch => new FluentAlignItems(ItemAlignmentOption.Stretch);

        /// <summary>
        /// Items are aligned as their baseline is aligned.
        /// Items are rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IFluentAlignItems Baseline => new FluentAlignItems(ItemAlignmentOption.Baseline);

        /// <summary>
        /// Flex items are rendered by default according to the supplied item alignment.
        /// Rendering is configurable based on CSS media query breakpoints.
        /// </summary>
        /// <param name="value">The default item alignment.</param>
        /// <returns>The item alignment configuration.</returns>
        public static IFluentAlignItemsWithValueOnBreakpoint Is(ItemAlignmentOption value) => new FluentAlignItems(value);
    }
}