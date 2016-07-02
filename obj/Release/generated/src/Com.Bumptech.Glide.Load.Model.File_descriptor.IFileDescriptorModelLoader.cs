using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Load.Model.File_descriptor {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bumptech.glide.load.model.file_descriptor']/interface[@name='FileDescriptorModelLoader']"
	[Register ("com/bumptech/glide/load/model/file_descriptor/FileDescriptorModelLoader", "", "Com.Bumptech.Glide.Load.Model.File_descriptor.IFileDescriptorModelLoaderInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IFileDescriptorModelLoader : global::Com.Bumptech.Glide.Load.Model.IModelLoader {

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/load/model/file_descriptor/FileDescriptorModelLoader", DoNotGenerateAcw=true)]
	internal class IFileDescriptorModelLoaderInvoker : global::Java.Lang.Object, IFileDescriptorModelLoader {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bumptech/glide/load/model/file_descriptor/FileDescriptorModelLoader");
		IntPtr class_ref;

		public static IFileDescriptorModelLoader GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFileDescriptorModelLoader> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bumptech.glide.load.model.file_descriptor.FileDescriptorModelLoader"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFileDescriptorModelLoaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IFileDescriptorModelLoaderInvoker); }
		}

	}

}
