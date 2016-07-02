using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Request.Target {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='PreloadTarget']"
	[global::Android.Runtime.Register ("com/bumptech/glide/request/target/PreloadTarget", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Z"})]
	public sealed partial class PreloadTarget : global::Com.Bumptech.Glide.Request.Target.SimpleTarget {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/request/target/PreloadTarget", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PreloadTarget); }
		}

		internal PreloadTarget (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_obtain_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='PreloadTarget']/method[@name='obtain' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("obtain", "(II)Lcom/bumptech/glide/request/target/PreloadTarget;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"Z"})]
		public static unsafe global::Com.Bumptech.Glide.Request.Target.PreloadTarget Obtain (int p0, int p1)
		{
			if (id_obtain_II == IntPtr.Zero)
				id_obtain_II = JNIEnv.GetStaticMethodID (class_ref, "obtain", "(II)Lcom/bumptech/glide/request/target/PreloadTarget;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.PreloadTarget> (JNIEnv.CallStaticObjectMethod  (class_ref, id_obtain_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
