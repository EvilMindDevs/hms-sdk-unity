namespace HuaweiMobileServices.Id
{
    using System.Collections.Generic;
    using HuaweiMobileServices.Utils;
    using HuaweiMobileServices.Base;
    using UnityEngine;

    // Wrapper for com.huawei.hms.support.hwid.request.HuaweiIdAuthParams
    public class HuaweiIdAuthParams : JavaObjectWrapper
    {

        internal HuaweiIdAuthParams(AndroidJavaObject javaObject) : base(javaObject) { }

        public static readonly Scope SCOPE_GAMES = new Scope("https://www.huawei.com/auth/games");

        public static readonly HuaweiIdAuthParams DEFAULT_AUTH_REQUEST_PARAM = (new HuaweiIdAuthParamsHelper()).SetId().SetProfile().CreateParams();

        public static readonly HuaweiIdAuthParams DEFAULT_AUTH_REQUEST_PARAM_GAME = (new HuaweiIdAuthParamsHelper()).SetScope(SCOPE_GAMES).CreateParams();

        public virtual IList<Scope> RequestScopeList
        {
            get => Call<AndroidJavaObject>("getRequestScopeList").AsListFromWrappable<Scope>();
        }

        public virtual IList<PermissionInfo> PermissionInfos
        {
            get => Call<AndroidJavaObject>("getPermissionInfos").AsListFromWrappable<PermissionInfo>();
        }

        public override bool Equals(object paramObject)
        {
            if (this == paramObject)
            {
                return true;
            }
            if (!(paramObject is HuaweiIdAuthParams))
            {
                return false;
            }
            HuaweiIdAuthParams huaweiIdAuthParams = (HuaweiIdAuthParams)paramObject;
            return (A(this.a, huaweiIdAuthParams.a) && A(this.b, huaweiIdAuthParams.b));
        }

        private bool A<T>(List<T> paramArrayList1, List<T> paramArrayList2)
        {
            if (paramArrayList1 == paramArrayList2)
            {
                return true;
            }
            if (paramArrayList1.Count != paramArrayList2.Count)
            {
                return false;
            }
            //JAVA TO C# CONVERTER TODO TASK: There is no .NET equivalent to the java.util.Collection 'containsAll' method:
            return paramArrayList1.containsAll(paramArrayList2);
        }

        //JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in C#:
        //ORIGINAL LINE: public String toJson() throws org.json.JSONException
        public virtual string ToJson()
        {
            return ToJsonObject().ToString();
        }

        //JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in C#:
        //ORIGINAL LINE: public org.json.JSONObject toJsonObject() throws org.json.JSONException
        public virtual JSONObject ToJsonObject()
        {
            JSONObject jSONObject = new JSONObject();
            if (null != this.a)
            {
                JSONArray jSONArray = new JSONArray();
                foreach (Scope scope in this.a)
                {
                    jSONArray.put(A(scope));
                }
                jSONObject.put("scopeArrayList", jSONArray);
            }
            if (null != this.b)
            {
                JSONArray jSONArray = new JSONArray();
                foreach (PermissionInfo permissionInfo in this.b)
                {
                    jSONArray.put(A(permissionInfo));
                }
                jSONObject.put("permissionArrayList", jSONArray);
            }
            return jSONObject;
        }

        //JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in C#:
        //ORIGINAL LINE: public static HuaweiIdAuthParams fromJson(String paramString) throws org.json.JSONException
        public static HuaweiIdAuthParams FromJson(string paramString)
        {
            if (TextUtils.isEmpty(paramString))
            {
                return null;
            }
            JSONObject jSONObject = new JSONObject(paramString);
            return FromJsonObject(jSONObject);
        }

        //JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in C#:
        //ORIGINAL LINE: public static HuaweiIdAuthParams fromJsonObject(org.json.JSONObject paramJSONObject) throws org.json.JSONException
        public static HuaweiIdAuthParams FromJsonObject(JSONObject paramJSONObject)
        {
            JSONArray jSONArray1 = paramJSONObject.getJSONArray("scopeArrayList");
            List<object> arrayList1 = new List<object>();
            if (null != jSONArray1)
            {
                for (sbyte b1 = 0; b1 < jSONArray1.length(); b1++)
                {
                    JSONObject jSONObject = jSONArray1.getJSONObject(b1);
                    arrayList1.Add(A(jSONObject));
                }
            }
            JSONArray jSONArray2 = paramJSONObject.getJSONArray("permissionArrayList");
            List<object> arrayList2 = new List<object>();
            if (null != jSONArray2)
            {
                for (sbyte b1 = 0; b1 < jSONArray2.length(); b1++)
                {
                    JSONObject jSONObject = jSONArray2.getJSONObject(b1);
                    arrayList2.Add(B(jSONObject));
                }
            }
            return new HuaweiIdAuthParams(arrayList1, arrayList2);
        }

        //JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in C#:
        //ORIGINAL LINE: private org.json.JSONObject a(com.huawei.hms.support.api.entity.auth.Scope paramScope) throws org.json.JSONException
        private JSONObject A(Scope paramScope)
        {
            JSONObject jSONObject = new JSONObject();
            if (null != paramScope.ScopeUri)
            {
                jSONObject.put("mScopeUri", paramScope.ScopeUri);
            }
            return jSONObject;
        }

        private static Scope A(JSONObject paramJSONObject)
        {
            string str = paramJSONObject.optString("mScopeUri", null);
            return new Scope(str);
        }

        //JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in C#:
        //ORIGINAL LINE: private org.json.JSONObject a(com.huawei.hms.support.api.entity.auth.PermissionInfo paramPermissionInfo) throws org.json.JSONException
        private JSONObject A(PermissionInfo paramPermissionInfo)
        {
            JSONObject jSONObject = new JSONObject();
            if (null != paramPermissionInfo.Permission)
            {
                jSONObject.put("permission", paramPermissionInfo.Permission);
            }
            return jSONObject;
        }

        private static PermissionInfo B(JSONObject paramJSONObject)
        {
            string str = paramJSONObject.optString("permission", null);
            return (new PermissionInfo()).setPermissionUri(str);
        }

        public override int GetHashCode()
        {
            null = 1;
            null = 31 * null + ((null == this.a) ? 0 : this.a.GetHashCode());
            return 31 * null + ((null == this.b) ? 0 : this.b.GetHashCode());
        }

        public virtual Scope[] ScopeArray
        {
            get
            {
                return (Scope[])this.a.ToArray();
            }
        }
    }

}