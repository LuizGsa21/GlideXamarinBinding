using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Model {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.load.model']/interface[@name='ModelLoader']"
	[Register ("com/bumptech/glide/load/model/ModelLoader", "", "Com.Bumptech.Glide.Load.Model.IModelLoaderInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "Y"})]
	public partial interface IModelLoader : IJavaObject {

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/load/model/ModelLoader", DoNotGenerateAcw=true)]
	internal class IModelLoaderInvoker : global::Java.Lang.Object, IModelLoader {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/load/model/ModelLoader");
		IntPtr class_ref;

		public static IModelLoader GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IModelLoader> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.load.model.ModelLoader"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IModelLoaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IModelLoaderInvoker); }
		}

	}

}
