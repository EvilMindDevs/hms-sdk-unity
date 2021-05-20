using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.CloudDB
{
    public class CloudDBZoneQuery : JavaObjectWrapper
    {
        
        public CloudDBZoneQuery(AndroidJavaObject javaObject) : base(javaObject) { }
        public CloudDBZoneQuery() : base("com.huawei.agconnect.cloud.database.CloudDBZoneQuery") { }

        private static AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.agconnect.cloud.database.CloudDBZoneQuery");

        public static CloudDBZoneQuery Where(AndroidJavaClass entityClass) => sJavaClass.CallStaticAsWrapper<CloudDBZoneQuery>("where", entityClass);

        public CloudDBZoneQuery EqualTo(string fieldName, long value) => CallAsWrapper<CloudDBZoneQuery>("equalTo", fieldName, value);
        public CloudDBZoneQuery EqualTo(string fieldName, string value) => CallAsWrapper<CloudDBZoneQuery>("equalTo", fieldName, value);
        public CloudDBZoneQuery EqualTo(string fieldName, int value) => CallAsWrapper<CloudDBZoneQuery>("equalTo", fieldName, value);
        public CloudDBZoneQuery EqualTo(string fieldName, double value) => CallAsWrapper<CloudDBZoneQuery>("equalTo", fieldName, value);
        public CloudDBZoneQuery EqualTo(string fieldName, float value) => CallAsWrapper<CloudDBZoneQuery>("equalTo", fieldName, value);
        public CloudDBZoneQuery EqualTo(string fieldName, Text value) => CallAsWrapper<CloudDBZoneQuery>("equalTo", fieldName, value);
        public CloudDBZoneQuery EqualTo(string fieldName, Date value) => CallAsWrapper<CloudDBZoneQuery>("equalTo", fieldName, value);
        public CloudDBZoneQuery EqualTo(string fieldName, bool value) => CallAsWrapper<CloudDBZoneQuery>("equalTo", fieldName, value);
        public CloudDBZoneQuery EqualTo(string fieldName, short value) => CallAsWrapper<CloudDBZoneQuery>("equalTo", fieldName, value);
        public CloudDBZoneQuery EqualTo(string fieldName, byte value) => CallAsWrapper<CloudDBZoneQuery>("equalTo", fieldName, value);
        public CloudDBZoneQuery NotEqualTo(string fieldName, long value) => CallAsWrapper<CloudDBZoneQuery>("notEqualTo", fieldName, value);
        public CloudDBZoneQuery NotEqualTo(string fieldName, double value) => CallAsWrapper<CloudDBZoneQuery>("notEqualTo", fieldName, value);
        public CloudDBZoneQuery NotEqualTo(string fieldName, float value) => CallAsWrapper<CloudDBZoneQuery>("notEqualTo", fieldName, value);
        public CloudDBZoneQuery NotEqualTo(string fieldName, int value) => CallAsWrapper<CloudDBZoneQuery>("notEqualTo", fieldName, value);
        public CloudDBZoneQuery NotEqualTo(string fieldName, short value) => CallAsWrapper<CloudDBZoneQuery>("notEqualTo", fieldName, value);
        public CloudDBZoneQuery NotEqualTo(string fieldName, byte value) => CallAsWrapper<CloudDBZoneQuery>("notEqualTo", fieldName, value);
        public CloudDBZoneQuery NotEqualTo(string fieldName, Text value) => CallAsWrapper<CloudDBZoneQuery>("notEqualTo", fieldName, value);
        public CloudDBZoneQuery NotEqualTo(string fieldName, bool value) => CallAsWrapper<CloudDBZoneQuery>("notEqualTo", fieldName, value);
        public CloudDBZoneQuery NotEqualTo(string fieldName, Date value) => CallAsWrapper<CloudDBZoneQuery>("notEqualTo", fieldName, value);
        public CloudDBZoneQuery NotEqualTo(string fieldName, string value) => CallAsWrapper<CloudDBZoneQuery>("notEqualTo", fieldName, value);
        public CloudDBZoneQuery GreaterThan(string fieldName, int value) => CallAsWrapper<CloudDBZoneQuery>("greaterThan", fieldName, value);
        public CloudDBZoneQuery GreaterThan(string fieldName, short value) => CallAsWrapper<CloudDBZoneQuery>("greaterThan", fieldName, value);
        public CloudDBZoneQuery GreaterThan(string fieldName, long value) => CallAsWrapper<CloudDBZoneQuery>("greaterThan", fieldName, value);
        public CloudDBZoneQuery GreaterThan(string fieldName, byte value) => CallAsWrapper<CloudDBZoneQuery>("greaterThan", fieldName, value);
        public CloudDBZoneQuery GreaterThan(string fieldName, Text value) => CallAsWrapper<CloudDBZoneQuery>("greaterThan", fieldName, value);
        public CloudDBZoneQuery GreaterThan(string fieldName, Date value) => CallAsWrapper<CloudDBZoneQuery>("greaterThan", fieldName, value);
        public CloudDBZoneQuery GreaterThan(string fieldName, string value) => CallAsWrapper<CloudDBZoneQuery>("greaterThan", fieldName, value);
        public CloudDBZoneQuery GreaterThan(string fieldName, float value) => CallAsWrapper<CloudDBZoneQuery>("greaterThan", fieldName, value);
        public CloudDBZoneQuery GreaterThan(string fieldName, double value) => CallAsWrapper<CloudDBZoneQuery>("greaterThan", fieldName, value);
        public CloudDBZoneQuery GreaterThanOrEqualTo(string fieldName, int value) => CallAsWrapper<CloudDBZoneQuery>("greaterThanOrEqualTo", fieldName, value);
        public CloudDBZoneQuery GreaterThanOrEqualTo(string fieldName, long value) => CallAsWrapper<CloudDBZoneQuery>("greaterThanOrEqualTo", fieldName, value);
        public CloudDBZoneQuery GreaterThanOrEqualTo(string fieldName, double value) => CallAsWrapper<CloudDBZoneQuery>("greaterThanOrEqualTo", fieldName, value);
        public CloudDBZoneQuery GreaterThanOrEqualTo(string fieldName, Text value) => CallAsWrapper<CloudDBZoneQuery>("greaterThanOrEqualTo", fieldName, value);
        public CloudDBZoneQuery GreaterThanOrEqualTo(string fieldName, float value) => CallAsWrapper<CloudDBZoneQuery>("greaterThanOrEqualTo", fieldName, value);
        public CloudDBZoneQuery GreaterThanOrEqualTo(string fieldName, string value) => CallAsWrapper<CloudDBZoneQuery>("greaterThanOrEqualTo", fieldName, value);
        public CloudDBZoneQuery GreaterThanOrEqualTo(string fieldName, Date value) => CallAsWrapper<CloudDBZoneQuery>("greaterThanOrEqualTo", fieldName, value);
        public CloudDBZoneQuery GreaterThanOrEqualTo(string fieldName, byte value) => CallAsWrapper<CloudDBZoneQuery>("greaterThanOrEqualTo", fieldName, value);
        public CloudDBZoneQuery GreaterThanOrEqualTo(string fieldName, short value) => CallAsWrapper<CloudDBZoneQuery>("greaterThanOrEqualTo", fieldName, value);
        public CloudDBZoneQuery LessThanOrEqualTo(string fieldName, int value) => CallAsWrapper<CloudDBZoneQuery>("lessThanOrEqualTo", fieldName, value);
        public CloudDBZoneQuery LessThanOrEqualTo(string fieldName, long value) => CallAsWrapper<CloudDBZoneQuery>("lessThanOrEqualTo", fieldName, value);
        public CloudDBZoneQuery LessThanOrEqualTo(string fieldName, double value) => CallAsWrapper<CloudDBZoneQuery>("lessThanOrEqualTo", fieldName, value);
        public CloudDBZoneQuery LessThanOrEqualTo(string fieldName, Text value) => CallAsWrapper<CloudDBZoneQuery>("lessThanOrEqualTo", fieldName, value);
        public CloudDBZoneQuery LessThanOrEqualTo(string fieldName, float value) => CallAsWrapper<CloudDBZoneQuery>("lessThanOrEqualTo", fieldName, value);
        public CloudDBZoneQuery LessThanOrEqualTo(string fieldName, string value) => CallAsWrapper<CloudDBZoneQuery>("lessThanOrEqualTo", fieldName, value);
        public CloudDBZoneQuery LessThanOrEqualTo(string fieldName, Date value) => CallAsWrapper<CloudDBZoneQuery>("lessThanOrEqualTo", fieldName, value);
        public CloudDBZoneQuery LessThanOrEqualTo(string fieldName, byte value) => CallAsWrapper<CloudDBZoneQuery>("lessThanOrEqualTo", fieldName, value);
        public CloudDBZoneQuery LessThanOrEqualTo(string fieldName, short value) => CallAsWrapper<CloudDBZoneQuery>("lessThanOrEqualTo", fieldName, value);
        public CloudDBZoneQuery LessThan(string fieldName, short value) => CallAsWrapper<CloudDBZoneQuery>("lessThan", fieldName, value);
        public CloudDBZoneQuery LessThan(string fieldName, double value) => CallAsWrapper<CloudDBZoneQuery>("lessThan", fieldName, value);
        public CloudDBZoneQuery LessThan(string fieldName, float value) => CallAsWrapper<CloudDBZoneQuery>("lessThan", fieldName, value);
        public CloudDBZoneQuery LessThan(string fieldName, string value) => CallAsWrapper<CloudDBZoneQuery>("lessThan", fieldName, value);
        public CloudDBZoneQuery LessThan(string fieldName, Text value) => CallAsWrapper<CloudDBZoneQuery>("lessThan", fieldName, value);
        public CloudDBZoneQuery LessThan(string fieldName, Date value) => CallAsWrapper<CloudDBZoneQuery>("lessThan", fieldName, value);
        public CloudDBZoneQuery LessThan(string fieldName, byte value) => CallAsWrapper<CloudDBZoneQuery>("lessThan", fieldName, value);
        public CloudDBZoneQuery LessThan(string fieldName, int value) => CallAsWrapper<CloudDBZoneQuery>("lessThan", fieldName, value);
        public CloudDBZoneQuery LessThan(string fieldName, long value) => CallAsWrapper<CloudDBZoneQuery>("lessThan", fieldName, value);
        public CloudDBZoneQuery In(string fieldName, int[] value) => CallAsWrapper<CloudDBZoneQuery>("in", fieldName, (object)value);
        public CloudDBZoneQuery In(string fieldName, long[] value) => CallAsWrapper<CloudDBZoneQuery>("in", fieldName, (object)value);
        public CloudDBZoneQuery In(string fieldName, double[] value) => CallAsWrapper<CloudDBZoneQuery>("in", fieldName, (object)value);
        public CloudDBZoneQuery In(string fieldName, short[] value) => CallAsWrapper<CloudDBZoneQuery>("in", fieldName, (object)value);
        public CloudDBZoneQuery In(string fieldName, byte[] value) => CallAsWrapper<CloudDBZoneQuery>("in", fieldName, (object)value);
        public CloudDBZoneQuery In(string fieldName, Date[] value) => CallAsWrapper<CloudDBZoneQuery>("in", fieldName, (object)value);
        public CloudDBZoneQuery In(string fieldName, Text[] value) => CallAsWrapper<CloudDBZoneQuery>("in", fieldName, (object)value);
        public CloudDBZoneQuery In(string fieldName, string[] value) => CallAsWrapper<CloudDBZoneQuery>("in", fieldName, (object)value);
        public CloudDBZoneQuery In(string fieldName, float[] value) => CallAsWrapper<CloudDBZoneQuery>("in", fieldName, (object)value);
        public CloudDBZoneQuery BbeginsWith(string fieldName, string value) => CallAsWrapper<CloudDBZoneQuery>("beginsWith", fieldName, value);
        public CloudDBZoneQuery BeginsWith(string fieldName, Text value) => CallAsWrapper<CloudDBZoneQuery>("beginsWith", fieldName, value);
        public CloudDBZoneQuery EndsWith(string fieldName, Text value) => CallAsWrapper<CloudDBZoneQuery>("endsWith", fieldName, value);
        public CloudDBZoneQuery EndsWith(string fieldName, string value) => CallAsWrapper<CloudDBZoneQuery>("endsWith", fieldName, value);
        public CloudDBZoneQuery Contains(string fieldName, string value) => CallAsWrapper<CloudDBZoneQuery>("contains", fieldName, value);
        public CloudDBZoneQuery Contains(string fieldName, Text value) => CallAsWrapper<CloudDBZoneQuery>("contains", fieldName, value);
        public CloudDBZoneQuery IsNull(string fieldName) => CallAsWrapper<CloudDBZoneQuery>("isNull", fieldName);
        public CloudDBZoneQuery IsNotNull(string fieldName) => CallAsWrapper<CloudDBZoneQuery>("isNotNull", fieldName);
        public CloudDBZoneQuery OrderByAsc(string fieldName) => CallAsWrapper<CloudDBZoneQuery>("orderByAsc", fieldName);
        public CloudDBZoneQuery OrderByDesc(string fieldName) => CallAsWrapper<CloudDBZoneQuery>("orderByDesc", fieldName);
        public CloudDBZoneQuery Limit(int count, int offset) => CallAsWrapper<CloudDBZoneQuery>("limit", count, offset);
        public CloudDBZoneQuery Limit(int count) => CallAsWrapper<CloudDBZoneQuery>("limit", count);

        public class CloudDBZoneQueryPolicy : JavaObjectWrapper
        {
            
            public CloudDBZoneQueryPolicy(AndroidJavaObject javaObject) : base(javaObject) { }
            public CloudDBZoneQueryPolicy() : base("com.huawei.agconnect.cloud.database.CloudDBZoneQuery$CloudDBZoneQueryPolicy") { }

            private static AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.agconnect.cloud.database.CloudDBZoneQuery$CloudDBZoneQueryPolicy");

            public static CloudDBZoneQueryPolicy CLOUDDBZONE_LOCAL_ONLY => sJavaClass.GetStaticAsWrapper<CloudDBZoneQueryPolicy>("POLICY_QUERY_FROM_LOCAL_ONLY");
            public static CloudDBZoneQueryPolicy CLOUDDBZONE_CLOUD_CACHE => sJavaClass.GetStaticAsWrapper<CloudDBZoneQueryPolicy>("POLICY_QUERY_FROM_CLOUD_ONLY");
        }
    }
}
