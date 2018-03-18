package md5b9dbb8ec24b97e67d95a1576873b4bbc;


public class GPSServiceBinder
	extends android.os.Binder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("NoClick.GPSServiceBinder, NoClick, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", GPSServiceBinder.class, __md_methods);
	}


	public GPSServiceBinder () throws java.lang.Throwable
	{
		super ();
		if (getClass () == GPSServiceBinder.class)
			mono.android.TypeManager.Activate ("NoClick.GPSServiceBinder, NoClick, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public GPSServiceBinder (md5b9dbb8ec24b97e67d95a1576873b4bbc.GPSService p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == GPSServiceBinder.class)
			mono.android.TypeManager.Activate ("NoClick.GPSServiceBinder, NoClick, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "NoClick.GPSService, NoClick, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
