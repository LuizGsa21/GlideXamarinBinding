using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide']/interface[@name='BitmapOptions']"
	[Register ("com/bumptech/glide/BitmapOptions", "", "Com.Bumptech.Glide.IBitmapOptionsInvoker")]
	public partial interface IBitmapOptions : IJavaObject {

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/BitmapOptions", DoNotGenerateAcw=true)]
	internal class IBitmapOptionsInvoker : global::Java.Lang.Object, IBitmapOptions {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/BitmapOptions");
		IntPtr class_ref;

		public static IBitmapOptions GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBitmapOptions> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.BitmapOptions"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBitmapOptionsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBitmapOptionsInvoker); }
		}

	}

}
