using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.load']/interface[@name='ResourceEncoder']"
	[Register ("com/bumptech/glide/load/ResourceEncoder", "", "Com.Bumptech.Glide.Load.IResourceEncoderInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IResourceEncoder : global::Com.Bumptech.Glide.Load.IEncoder {

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/load/ResourceEncoder", DoNotGenerateAcw=true)]
	internal class IResourceEncoderInvoker : global::Java.Lang.Object, IResourceEncoder {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/load/ResourceEncoder");
		IntPtr class_ref;

		public static IResourceEncoder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IResourceEncoder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.load.ResourceEncoder"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IResourceEncoderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IResourceEncoderInvoker); }
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Load.IResourceEncoder __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Load.IResourceEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		IntPtr id_getId;
		public unsafe string Id {
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
