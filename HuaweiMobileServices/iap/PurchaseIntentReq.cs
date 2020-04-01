namespace HuaweiMobileServices.IAP
{
	using IMessageEntity = com.huawei.hms.core.aidl.IMessageEntity;
	using Packed = com.huawei.hms.core.aidl.annotation.Packed;

	public class PurchaseIntentReq : IMessageEntity
	{
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Packed private String productId;
	  private string productId;

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Packed private int priceType;
	  private int priceType;

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Packed private String developerPayload;
	  private string developerPayload;

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Packed private String transactionId = createTransactionId();
	  private string transactionId = createTransactionId();

	  public virtual string DeveloperPayload
	  {
		  get
		  {
			  return this.developerPayload;
		  }
		  set
		  {
			  this.developerPayload = value;
		  }
	  }

	  public virtual int PriceType
	  {
		  get
		  {
			  return this.priceType;
		  }
		  set
		  {
			  this.priceType = value;
		  }
	  }

	  public virtual string ProductId
	  {
		  get
		  {
			  return this.productId;
		  }
		  set
		  {
			  this.productId = value;
		  }
	  }




	  private static string createTransactionId()
	  { // Byte code:
		//   0: new java/lang/StringBuilder
		//   3: dup
		//   4: invokespecial <init> : ()V
		//   7: invokestatic currentTimeMillis : ()J
		//   10: invokevirtual append : (J)Ljava/lang/StringBuilder;
		//   13: invokevirtual toString : ()Ljava/lang/String;
		//   16: astore_0
		//   17: new java/security/SecureRandom
		//   20: dup
		//   21: invokespecial <init> : ()V
		//   24: astore_1
		//   25: getstatic java/util/Locale.ENGLISH : Ljava/util/Locale;
		//   28: ldc '%06d'
		//   30: iconst_1
		//   31: anewarray java/lang/Object
		//   34: dup
		//   35: iconst_0
		//   36: aload_1
		//   37: ldc 1000000
		//   39: invokevirtual nextInt : (I)I
		//   42: invokestatic valueOf : (I)Ljava/lang/Integer;
		//   45: aastore
		//   46: invokestatic format : (Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;
		//   49: astore_1
		//   50: new java/lang/StringBuilder
		//   53: dup
		//   54: invokespecial <init> : ()V
		//   57: aload_0
		//   58: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   61: aload_1
		//   62: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   65: invokevirtual toString : ()Ljava/lang/String;
		//   68: areturn
		// Line number table:
		//   Java source line number -> byte code offset
		//   #69	-> 0
		//   #71	-> 17
		//   #73	-> 25
		//   #74	-> 50 }
	  }

	}