﻿namespace Nop.Plugin.Payments.Razorpay
{
    /// <summary>
    /// Represents constants of the Razorpay plugin
    /// </summary>
    public static class RazorpayDefaults
    {
        /// <summary>
        /// Name of the view component to display seal in public store
        /// </summary>
        public const string VIEW_COMPONENT_NAME = "PaymentRazorpay";

        /// <summary>
        /// Gets pay link url
        /// </summary>
        public static string PayUri => "https://secure.ccavenue.com/transaction/transaction.do?command=initiateTransaction";

        /// <summary>
        /// Gets the return route name
        /// </summary>
        public static string ReturnRouteName => "Plugin.Payments.Razorpay.Return";
    }
}
