using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Model.Stream {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.load.model.stream']/interface[@name='StreamModelLoader']"
	[Register ("com/bumptech/glide/load/model/stream/StreamModelLoader", "", "Com.Bumptech.Glide.Load.Model.Stream.IStreamModelLoaderInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IStreamModelLoader : global::Com.Bumptech.Glide.Load.Model.IModelLoader {

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/load/model/stream/StreamModelLoader", DoNotGenerateAcw=true)]
	internal class IStreamModelLoaderInvoker : global::Java.Lang.Object, IStreamModelLoader {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/load/model/stream/StreamModelLoader");
		IntPtr class_ref;

		public static IStreamModelLoader GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStreamModelLoader> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.load.model.stream.StreamModelLoader"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStreamModelLoaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IStreamModelLoaderInvoker); }
		}

	}

}
