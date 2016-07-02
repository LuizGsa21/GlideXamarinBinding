using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide']/interface[@name='DrawableOptions']"
	[Register ("com/bumptech/glide/DrawableOptions", "", "Com.Bumptech.Glide.IDrawableOptionsInvoker")]
	public partial interface IDrawableOptions : IJavaObject {

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/DrawableOptions", DoNotGenerateAcw=true)]
	internal class IDrawableOptionsInvoker : global::Java.Lang.Object, IDrawableOptions {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/DrawableOptions");
		IntPtr class_ref;

		public static IDrawableOptions GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDrawableOptions> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.DrawableOptions"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDrawableOptionsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDrawableOptionsInvoker); }
		}

	}

}
