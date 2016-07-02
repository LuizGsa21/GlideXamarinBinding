using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide']/interface[@name='DownloadOptions']"
	[Register ("com/bumptech/glide/DownloadOptions", "", "Com.Bumptech.Glide.IDownloadOptionsInvoker")]
	public partial interface IDownloadOptions : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/interface[@name='DownloadOptions']/method[@name='downloadOnly' and count(parameter)=1 and parameter[1][@type='Y']]"
		[Register ("downloadOnly", "(Lcom/bumptech/glide/request/target/Target;)Lcom/bumptech/glide/request/target/Target;", "GetDownloadOnly_Lcom_bumptech_glide_request_target_Target_Handler:Com.Bumptech.Glide.IDownloadOptionsInvoker, GlideAssembly")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"Y extends com.bumptech.glide.request.target.Target<java.io.File>"})]
		global::Java.Lang.Object DownloadOnly (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide']/interface[@name='DownloadOptions']/method[@name='downloadOnly' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("downloadOnly", "(II)Lcom/bumptech/glide/request/FutureTarget;", "GetDownloadOnly_IIHandler:Com.Bumptech.Glide.IDownloadOptionsInvoker, GlideAssembly")]
		global::Com.Bumptech.Glide.Request.IFutureTarget DownloadOnly (int p0, int p1);

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/DownloadOptions", DoNotGenerateAcw=true)]
	internal class IDownloadOptionsInvoker : global::Java.Lang.Object, IDownloadOptions {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/DownloadOptions");
		IntPtr class_ref;

		public static IDownloadOptions GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDownloadOptions> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.DownloadOptions"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDownloadOptionsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDownloadOptionsInvoker); }
		}

		static Delegate cb_downloadOnly_Lcom_bumptech_glide_request_target_Target_;
#pragma warning disable 0169
		static Delegate GetDownloadOnly_Lcom_bumptech_glide_request_target_Target_Handler ()
		{
			if (cb_downloadOnly_Lcom_bumptech_glide_request_target_Target_ == null)
				cb_downloadOnly_Lcom_bumptech_glide_request_target_Target_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DownloadOnly_Lcom_bumptech_glide_request_target_Target_);
			return cb_downloadOnly_Lcom_bumptech_glide_request_target_Target_;
		}

		static IntPtr n_DownloadOnly_Lcom_bumptech_glide_request_target_Target_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.IDownloadOptions __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.IDownloadOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DownloadOnly (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_downloadOnly_Lcom_bumptech_glide_request_target_Target_;
		public unsafe global::Java.Lang.Object DownloadOnly (global::Java.Lang.Object p0)
		{
			if (id_downloadOnly_Lcom_bumptech_glide_request_target_Target_ == IntPtr.Zero)
				id_downloadOnly_Lcom_bumptech_glide_request_target_Target_ = JNIEnv.GetMethodID (class_ref, "downloadOnly", "(Lcom/bumptech/glide/request/target/Target;)Lcom/bumptech/glide/request/target/Target;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_downloadOnly_Lcom_bumptech_glide_request_target_Target_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_downloadOnly_II;
#pragma warning disable 0169
		static Delegate GetDownloadOnly_IIHandler ()
		{
			if (cb_downloadOnly_II == null)
				cb_downloadOnly_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_DownloadOnly_II);
			return cb_downloadOnly_II;
		}

		static IntPtr n_DownloadOnly_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Bumptech.Glide.IDownloadOptions __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.IDownloadOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DownloadOnly (p0, p1));
		}
#pragma warning restore 0169

		IntPtr id_downloadOnly_II;
		public unsafe global::Com.Bumptech.Glide.Request.IFutureTarget DownloadOnly (int p0, int p1)
		{
			if (id_downloadOnly_II == IntPtr.Zero)
				id_downloadOnly_II = JNIEnv.GetMethodID (class_ref, "downloadOnly", "(II)Lcom/bumptech/glide/request/FutureTarget;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.IFutureTarget> (JNIEnv.CallObjectMethod (Handle, id_downloadOnly_II, __args), JniHandleOwnership.TransferLocalRef);
		}

	}

}
