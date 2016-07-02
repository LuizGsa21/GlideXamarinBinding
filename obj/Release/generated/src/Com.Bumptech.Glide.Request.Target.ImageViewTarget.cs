using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bumptech.Glide.Request.Target {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='ImageViewTarget']"
	[global::Android.Runtime.Register ("com/bumptech/glide/request/target/ImageViewTarget", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Z"})]
	public abstract partial class ImageViewTarget : global::Com.Bumptech.Glide.Request.Target.ViewTarget, global::Com.Bumptech.Glide.Request.Animation.IGlideAnimationViewAdapter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bumptech/glide/request/target/ImageViewTarget", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageViewTarget); }
		}

		protected ImageViewTarget (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_widget_ImageView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='ImageViewTarget']/constructor[@name='ImageViewTarget' and count(parameter)=1 and parameter[1][@type='android.widget.ImageView']]"
		[Register (".ctor", "(Landroid/widget/ImageView;)V", "")]
		public unsafe ImageViewTarget (global::Android.Widget.ImageView p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ImageViewTarget)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/widget/ImageView;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/widget/ImageView;)V", __args);
					return;
				}

				if (id_ctor_Landroid_widget_ImageView_ == IntPtr.Zero)
					id_ctor_Landroid_widget_ImageView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/widget/ImageView;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_widget_ImageView_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_widget_ImageView_, __args);
			} finally {
			}
		}

		static Delegate cb_getCurrentDrawable;
#pragma warning disable 0169
		static Delegate GetGetCurrentDrawableHandler ()
		{
			if (cb_getCurrentDrawable == null)
				cb_getCurrentDrawable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentDrawable);
			return cb_getCurrentDrawable;
		}

		static IntPtr n_GetCurrentDrawable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bumptech.Glide.Request.Target.ImageViewTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ImageViewTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentDrawable);
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentDrawable;
		public virtual unsafe global::Android.Graphics.Drawables.Drawable CurrentDrawable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='ImageViewTarget']/method[@name='getCurrentDrawable' and count(parameter)=0]"
			[Register ("getCurrentDrawable", "()Landroid/graphics/drawable/Drawable;", "GetGetCurrentDrawableHandler")]
			get {
				if (id_getCurrentDrawable == IntPtr.Zero)
					id_getCurrentDrawable = JNIEnv.GetMethodID (class_ref, "getCurrentDrawable", "()Landroid/graphics/drawable/Drawable;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_getCurrentDrawable), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentDrawable", "()Landroid/graphics/drawable/Drawable;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_setDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_setDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bumptech.Glide.Request.Target.ImageViewTarget __this = global::Java.Lang.Object.GetObject<global::Com.Bumptech.Glide.Request.Target.ImageViewTarget> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDrawable_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.request.target']/class[@name='ImageViewTarget']/method[@name='setDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetDrawable (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDrawable_Landroid_graphics_drawable_Drawable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDrawable", "(Landroid/graphics/drawable/Drawable;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/bumptech/glide/request/target/ImageViewTarget", DoNotGenerateAcw=true)]
	internal partial class ImageViewTargetInvoker : ImageViewTarget {

		public ImageViewTargetInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageViewTargetInvoker); }
		}

	}

}
