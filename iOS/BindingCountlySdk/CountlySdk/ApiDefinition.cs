using System;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using UIKit;
using UserNotifications;


namespace CountlySdk
{
    // @protocol CountlyUserDetailsNullableString <NSObject>
       [BaseType(typeof(NSObject))]
    [Model]
	interface CountlyUserDetailsNullableString 
       {
       }
    
       // @interface NSStringWithCountlyUserDetailsNullableString (NSString) <CountlyUserDetailsNullableString>
       [Category]
       [BaseType(typeof(NSString))]
       interface NSString_NSStringWithCountlyUserDetailsNullableString:CountlyUserDetailsNullableString
       {
       }
    
       // @interface NSNullWithCountlyUserDetailsNullableString (NSNull) <CountlyUserDetailsNullableString>
       [Category]
       [BaseType(typeof(NSNull))]
       interface NSNull_NSNullWithCountlyUserDetailsNullableString:CountlyUserDetailsNullableString
       {
       }
    
       // @protocol CountlyUserDetailsNullableDictionary <NSObject>
       [BaseType(typeof(NSObject))]
    [Model]
       interface ICountlyUserDetailsNullableDictionary
       {
       }
    
       // @interface NSDictionaryWithCountlyUserDetailsNullableDictionary (NSDictionary) <CountlyUserDetailsNullableDictionary>
       [Category]
       [BaseType(typeof(NSDictionary))]
       interface NSDictionary_NSDictionaryWithCountlyUserDetailsNullableDictionary:ICountlyUserDetailsNullableDictionary
    {
    }
    
    // @interface NSNullWithCountlyUserDetailsNullableDictionary (NSNull) <CountlyUserDetailsNullableDictionary>
    [Category]
    [BaseType(typeof(NSNull))]
    interface NSNull_NSNullWithCountlyUserDetailsNullableDictionary :ICountlyUserDetailsNullableDictionary
    {
    }
    
    // @protocol CountlyUserDetailsNullableNumber <NSObject>
    [BaseType(typeof(NSObject))]
    [Model]
    interface ICountlyUserDetailsNullableNumber
    {
    }
    
    // @interface NSDictionaryWithCountlyUserDetailsNullableNumber (NSNumber) <CountlyUserDetailsNullableNumber>
    [Category]
    [BaseType(typeof(NSNumber))]
    interface NSNumber_NSDictionaryWithCountlyUserDetailsNullableNumber:ICountlyUserDetailsNullableNumber
    {
    }
    
    // @interface NSNullWithCountlyUserDetailsNullableNumber (NSNull) <CountlyUserDetailsNullableNumber>
    [Category]
    [BaseType(typeof(NSNull))]
    interface NSNull_NSNullWithCountlyUserDetailsNullableNumber :ICountlyUserDetailsNullableNumber
    {
    }
    
    //[Static]
    //[Verify(ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const kCountlyLocalPicturePath;
		[Field("kCountlyLocalPicturePath", "__Internal")]
		NSString kCountlyLocalPicturePath { get; }
	}

	// @interface CountlyUserDetails : NSObject
	[BaseType(typeof(NSObject))]

	interface CountlyUserDetails
	{
		// @property (nonatomic, strong) id<CountlyUserDetailsNullableString> name;
		[Export("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (nonatomic, strong) id<CountlyUserDetailsNullableString> username;
		[Export("username", ArgumentSemantic.Strong)]
		string Username { get; set; }

		// @property (nonatomic, strong) id<CountlyUserDetailsNullableString> email;
		[Export("email", ArgumentSemantic.Strong)]
		string Email { get; set; }

		// @property (nonatomic, strong) id<CountlyUserDetailsNullableString> organization;
		[Export("organization", ArgumentSemantic.Strong)]
		string Organization { get; set; }

		// @property (nonatomic, strong) id<CountlyUserDetailsNullableString> phone;
		[Export("phone", ArgumentSemantic.Strong)]
		string Phone { get; set; }

		// @property (nonatomic, strong) id<CountlyUserDetailsNullableString> gender;
		[Export("gender", ArgumentSemantic.Strong)]
		string Gender { get; set; }

		// @property (nonatomic, strong) id<CountlyUserDetailsNullableString> pictureURL;
		[Export("pictureURL", ArgumentSemantic.Strong)]
		string PictureURL { get; set; }

		// @property (nonatomic, strong) id<CountlyUserDetailsNullableString> pictureLocalPath;
		[Export("pictureLocalPath", ArgumentSemantic.Strong)]
		string PictureLocalPath { get; set; }

		// @property (nonatomic, strong) id<CountlyUserDetailsNullableNumber> birthYear;
		[Export("birthYear", ArgumentSemantic.Strong)]
		string BirthYear { get; set; }

		// @property (nonatomic, strong) id<CountlyUserDetailsNullableDictionary> custom;
		[Export("custom", ArgumentSemantic.Strong)]
		string Custom { get; set; }

		// +(instancetype)sharedInstance;
		[Static]
		[Export("sharedInstance")]
		CountlyUserDetails SharedInstance();

		// -(void)recordUserDetails __attribute__((deprecated("Use 'save' method instead!")));
		[Export("recordUserDetails")]
		void RecordUserDetails();

		// -(void)set:(NSString *)key value:(NSString *)value;
		[Export("set:value:")]
		void Set(string key, string value);

		// -(void)setOnce:(NSString *)key value:(NSString *)value;
		[Export("setOnce:value:")]
		void SetOnce(string key, string value);

		// -(void)unSet:(NSString *)key;
		[Export("unSet:")]
		void UnSet(string key);

		// -(void)increment:(NSString *)key;
		[Export("increment:")]
		void Increment(string key);

		// -(void)incrementBy:(NSString *)key value:(NSNumber *)value;
		[Export("incrementBy:value:")]
		void IncrementBy(string key, NSNumber value);

		// -(void)multiply:(NSString *)key value:(NSNumber *)value;
		[Export("multiply:value:")]
		void Multiply(string key, NSNumber value);

		// -(void)max:(NSString *)key value:(NSNumber *)value;
		[Export("max:value:")]
		void Max(string key, NSNumber value);

		// -(void)min:(NSString *)key value:(NSNumber *)value;
		[Export("min:value:")]
		void Min(string key, NSNumber value);

		// -(void)push:(NSString *)key value:(NSString *)value;
		[Export("push:value:")]
		void Push(string key, string value);

		// -(void)push:(NSString *)key values:(NSArray *)value;
		[Export("push:values:")]
		//[Verify(StronglyTypedNSArray)]
		void Push(string key, NSObject[] value);

		// -(void)pushUnique:(NSString *)key value:(NSString *)value;
		[Export("pushUnique:value:")]
		void PushUnique(string key, string value);

		// -(void)pushUnique:(NSString *)key values:(NSArray *)value;
		[Export("pushUnique:values:")]
		//[Verify(StronglyTypedNSArray)]
		void PushUnique(string key, NSObject[] value);

		// -(void)pull:(NSString *)key value:(NSString *)value;
		[Export("pull:value:")]
		void Pull(string key, string value);

		// -(void)pull:(NSString *)key values:(NSArray *)value;
		[Export("pull:values:")]
	//	[Verify(StronglyTypedNSArray)]
		void Pull(string key, NSObject[] value);

		// -(void)save;
		[Export("save")]
		void Save();
	}

	[Static]
	//[Verify(ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const CLYPushNotifications;
		[Field("CLYPushNotifications", "__Internal")]
		NSString CLYPushNotifications { get; }

		// extern NSString *const CLYMessaging __attribute__((deprecated("Use CLYPushNotifications instead!")));
		[Field("CLYMessaging", "__Internal")]
		NSString CLYMessaging { get; }

		// extern NSString *const CLYCrashReporting;
		[Field("CLYCrashReporting", "__Internal")]
		NSString CLYCrashReporting { get; }

		// extern NSString *const CLYAutoViewTracking;
		[Field("CLYAutoViewTracking", "__Internal")]
		NSString CLYAutoViewTracking { get; }

		// extern NSString *const CLYIDFV;
		[Field("CLYIDFV", "__Internal")]
		NSString CLYIDFV { get; }

		// extern NSString *const CLYIDFA __attribute__((deprecated("Use CLYIDFV instead!")));
		[Field("CLYIDFA", "__Internal")]
		NSString CLYIDFA { get; }

		// extern NSString *const CLYOpenUDID __attribute__((deprecated("Use CLYIDFV instead!")));
		[Field("CLYOpenUDID", "__Internal")]
		NSString CLYOpenUDID { get; }
	}

	// @interface CountlyConfig : NSObject
	[BaseType(typeof(NSObject))]
	interface CountlyConfig
	{
		// @property (nonatomic, strong) NSString * host;
		[Export("host", ArgumentSemantic.Strong)]
		string Host { get; set; }

		// @property (nonatomic, strong) NSString * appKey;
		[Export("appKey", ArgumentSemantic.Strong)]
		string AppKey { get; set; }

		// @property (nonatomic, strong) NSArray * features;
		[Export("features", ArgumentSemantic.Strong)]
		//[Verify(StronglyTypedNSArray)]
		NSObject[] Features { get; set; }

		// @property (nonatomic) BOOL enableDebug;
		[Export("enableDebug")]
		bool EnableDebug { get; set; }

		// @property (nonatomic, strong) NSDictionary * launchOptions;
		[Export("launchOptions", ArgumentSemantic.Strong)]
		NSDictionary LaunchOptions { get; set; }

		// @property (nonatomic) BOOL isTestDevice;
		[Export("isTestDevice")]
		bool IsTestDevice { get; set; }

		// @property (nonatomic) BOOL sendPushTokenAlways;
		[Export("sendPushTokenAlways")]
		bool SendPushTokenAlways { get; set; }

		// @property (nonatomic) BOOL doNotShowAlertForNotifications;
		[Export("doNotShowAlertForNotifications")]
		bool DoNotShowAlertForNotifications { get; set; }

		// @property (nonatomic, strong) NSDictionary * crashSegmentation;
		[Export("crashSegmentation", ArgumentSemantic.Strong)]
		NSDictionary CrashSegmentation { get; set; }

		// @property (nonatomic, strong) NSString * deviceID;
		[Export("deviceID", ArgumentSemantic.Strong)]
		string DeviceID { get; set; }

		// @property (nonatomic) BOOL forceDeviceIDInitialization;
		[Export("forceDeviceIDInitialization")]
		bool ForceDeviceIDInitialization { get; set; }

		// @property (nonatomic) BOOL manualSessionHandling;
		[Export("manualSessionHandling")]
		bool ManualSessionHandling { get; set; }

		// @property (nonatomic) NSTimeInterval updateSessionPeriod;
		[Export("updateSessionPeriod")]
		double UpdateSessionPeriod { get; set; }

		// @property (nonatomic) NSUInteger eventSendThreshold;
		[Export("eventSendThreshold")]
		nuint EventSendThreshold { get; set; }

		// @property (nonatomic) NSUInteger storedRequestsLimit;
		[Export("storedRequestsLimit")]
		nuint StoredRequestsLimit { get; set; }

		// @property (nonatomic) BOOL alwaysUsePOST;
		[Export("alwaysUsePOST")]
		bool AlwaysUsePOST { get; set; }

		// @property (nonatomic) BOOL enableAppleWatch;
		[Export("enableAppleWatch")]
		bool EnableAppleWatch { get; set; }

		// @property (nonatomic, strong) NSString * ISOCountryCode;
		[Export("ISOCountryCode", ArgumentSemantic.Strong)]
		string ISOCountryCode { get; set; }

		// @property (nonatomic, strong) NSString * city;
		[Export("city", ArgumentSemantic.Strong)]
		string City { get; set; }

		// @property (nonatomic) CLLocationCoordinate2D location;
		[Export("location", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D Location { get; set; }

		// @property (nonatomic) NSString * IP;
		[Export("IP")]
		string IP { get; set; }

		// @property (nonatomic, strong) NSArray * pinnedCertificates;
		[Export("pinnedCertificates", ArgumentSemantic.Strong)]
		//[Verify(StronglyTypedNSArray)]
		NSObject[] PinnedCertificates { get; set; }

		// @property (nonatomic, strong) NSString * customHeaderFieldName;
		[Export("customHeaderFieldName", ArgumentSemantic.Strong)]
		string CustomHeaderFieldName { get; set; }

		// @property (nonatomic, strong) NSString * customHeaderFieldValue;
		[Export("customHeaderFieldValue", ArgumentSemantic.Strong)]
		string CustomHeaderFieldValue { get; set; }

		// @property (nonatomic, strong) NSString * secretSalt;
		[Export("secretSalt", ArgumentSemantic.Strong)]
		string SecretSalt { get; set; }

		// @property (nonatomic, strong) NSString * starRatingMessage;
		[Export("starRatingMessage", ArgumentSemantic.Strong)]
		string StarRatingMessage { get; set; }

		// @property (nonatomic) NSUInteger starRatingSessionCount;
		[Export("starRatingSessionCount")]
		nuint StarRatingSessionCount { get; set; }

		// @property (nonatomic) BOOL starRatingDisableAskingForEachAppVersion;
		[Export("starRatingDisableAskingForEachAppVersion")]
		bool StarRatingDisableAskingForEachAppVersion { get; set; }

		// @property (copy, nonatomic) void (^starRatingCompletion)(NSInteger);
		[Export("starRatingCompletion", ArgumentSemantic.Copy)]
		Action<nint> StarRatingCompletion { get; set; }
	}

	// @interface Countly : NSObject
	[BaseType(typeof(NSObject))]
	interface Countly
	{
		// +(instancetype)sharedInstance;
		[Static]
		[Export("sharedInstance")]
		Countly SharedInstance();

		// -(void)startWithConfig:(CountlyConfig *)config;
		[Export("startWithConfig:")]
		void StartWithConfig(CountlyConfig config);

		// -(void)setNewDeviceID:(NSString *)deviceID onServer:(BOOL)onServer;
		[Export("setNewDeviceID:onServer:")]
		void SetNewDeviceID(string deviceID, bool onServer);

		// -(void)setCustomHeaderFieldValue:(NSString *)customHeaderFieldValue;
		[Export("setCustomHeaderFieldValue:")]
		void SetCustomHeaderFieldValue(string customHeaderFieldValue);

		// -(void)beginSession;
		[Export("beginSession")]
		void BeginSession();

		// -(void)updateSession;
		[Export("updateSession")]
		void UpdateSession();

		// -(void)endSession;
		[Export("endSession")]
		void EndSession();

		// -(void)recordEvent:(NSString *)key;
		[Export("recordEvent:")]
		void RecordEvent(string key);

		// -(void)recordEvent:(NSString *)key count:(NSUInteger)count;
		[Export("recordEvent:count:")]
		void RecordEvent(string key, nuint count);

		// -(void)recordEvent:(NSString *)key sum:(double)sum;
		[Export("recordEvent:sum:")]
		void RecordEvent(string key, double sum);

		// -(void)recordEvent:(NSString *)key duration:(NSTimeInterval)duration;
		//[Export("recordEvent:duration:")]
		//void RecordEvent(string key, double duration);

		// -(void)recordEvent:(NSString *)key count:(NSUInteger)count sum:(double)sum;
		[Export("recordEvent:count:sum:")]
		void RecordEvent(string key, nuint count, double sum);

		// -(void)recordEvent:(NSString *)key segmentation:(NSDictionary *)segmentation;
		[Export("recordEvent:segmentation:")]
		void RecordEvent(string key, NSDictionary segmentation);

		// -(void)recordEvent:(NSString *)key segmentation:(NSDictionary *)segmentation count:(NSUInteger)count;
		[Export("recordEvent:segmentation:count:")]
		void RecordEvent(string key, NSDictionary segmentation, nuint count);

		// -(void)recordEvent:(NSString *)key segmentation:(NSDictionary *)segmentation count:(NSUInteger)count sum:(double)sum;
		[Export("recordEvent:segmentation:count:sum:")]
		void RecordEvent(string key, NSDictionary segmentation, nuint count, double sum);

		// -(void)recordEvent:(NSString *)key segmentation:(NSDictionary *)segmentation count:(NSUInteger)count sum:(double)sum duration:(NSTimeInterval)duration;
		[Export("recordEvent:segmentation:count:sum:duration:")]
		void RecordEvent(string key, NSDictionary segmentation, nuint count, double sum, double duration);

		// -(void)startEvent:(NSString *)key;
		[Export("startEvent:")]
		void StartEvent(string key);

		// -(void)endEvent:(NSString *)key;
		[Export("endEvent:")]
		void EndEvent(string key);

		// -(void)endEvent:(NSString *)key segmentation:(NSDictionary *)segmentation count:(NSUInteger)count sum:(double)sum;
		[Export("endEvent:segmentation:count:sum:")]
		void EndEvent(string key, NSDictionary segmentation, nuint count, double sum);

		// -(void)askForNotificationPermission;
		[Export("askForNotificationPermission")]
		void AskForNotificationPermission();

		// -(void)askForNotificationPermissionWithOptions:(UNAuthorizationOptions)options completionHandler:(void (^)(BOOL, NSError *))completionHandler;
		[Export("askForNotificationPermissionWithOptions:completionHandler:")]
		void AskForNotificationPermissionWithOptions(UNAuthorizationOptions options, Action<bool, NSError> completionHandler);

		// -(void)recordLocation:(CLLocationCoordinate2D)coordinate;
		[Export("recordLocation:")]
		void RecordLocation(CLLocationCoordinate2D coordinate);

		// -(void)recordHandledException:(NSException *)exception;
		[Export("recordHandledException:")]
		void RecordHandledException(NSException exception);

		// -(void)crashLog:(NSString *)format, ... __attribute__((format(NSString, 1, 2)));

		[Export("crashLog:", IsVariadic = true)]
		void CrashLog(string format, IntPtr varArgs);

		// -(void)addExceptionForAPM:(NSString *)exceptionURL;
		[Export("addExceptionForAPM:")]
		void AddExceptionForAPM(string exceptionURL);

		// -(void)removeExceptionForAPM:(NSString *)exceptionURL;
		[Export("removeExceptionForAPM:")]
		void RemoveExceptionForAPM(string exceptionURL);

		// -(void)reportView:(NSString *)viewName;
		[Export("reportView:")]
		void ReportView(string viewName);

		// -(void)addExceptionForAutoViewTracking:(NSString *)exception;
		[Export("addExceptionForAutoViewTracking:")]
		void AddExceptionForAutoViewTracking(string exception);

		// -(void)removeExceptionForAutoViewTracking:(NSString *)exception;
		[Export("removeExceptionForAutoViewTracking:")]
		void RemoveExceptionForAutoViewTracking(string exception);

		// @property (nonatomic) BOOL isAutoViewTrackingEnabled;
		[Export("isAutoViewTrackingEnabled")]
		bool IsAutoViewTrackingEnabled { get; set; }

		// +(CountlyUserDetails *)user;
		[Static]
		[Export("user")]
		//[Verify(MethodToProperty)]
		CountlyUserDetails User { get; }

		// -(void)userLoggedIn:(NSString *)userID;
		[Export("userLoggedIn:")]
		void UserLoggedIn(string userID);

		// -(void)userLoggedOut;
		[Export("userLoggedOut")]
		void UserLoggedOut();

		// -(void)askForStarRating:(void (^)(NSInteger))completion;
		[Export("askForStarRating:")]
		void AskForStarRating(Action<nint> completion);
	}

	// @interface CountlyAPM : NSObject
	[BaseType(typeof(NSObject))]
	interface CountlyAPM
	{
		// +(instancetype)sharedInstance;
		[Static]
		[Export("sharedInstance")]
		CountlyAPM SharedInstance();

		// -(void)startAPM;
		[Export("startAPM")]
		void StartAPM();

		// -(void)addExceptionForAPM:(NSString *)exceptionURL;
		[Export("addExceptionForAPM:")]
		void AddExceptionForAPM(string exceptionURL);

		// -(void)removeExceptionForAPM:(NSString *)exceptionURL;
		[Export("removeExceptionForAPM:")]
		void RemoveExceptionForAPM(string exceptionURL);

		// -(BOOL)isException:(NSURLRequest *)request;
		[Export("isException:")]
		bool IsException(NSUrlRequest request);
	}

	// @interface CountlyAPMNetworkLog : NSObject <NSURLConnectionDataDelegate, NSURLConnectionDelegate>
	[BaseType(typeof(NSObject))]
	interface CountlyAPMNetworkLog : INSUrlConnectionDataDelegate, INSUrlConnectionDelegate
	{
		// +(instancetype)logWithRequest:(NSURLRequest *)request andOriginalDelegate:(id)originalDelegate startNow:(BOOL)startNow;
		[Static]
		[Export("logWithRequest:andOriginalDelegate:startNow:")]
		CountlyAPMNetworkLog LogWithRequest(NSUrlRequest request, NSObject originalDelegate, bool startNow);

		// -(void)start;
		[Export("start")]
		void Start();

		// -(void)updateWithResponse:(NSURLResponse *)response;
		[Export("updateWithResponse:")]
		void UpdateWithResponse(NSUrlResponse response);

		// -(void)finish;
		[Export("finish")]
		void Finish();

		// -(void)finishWithStatusCode:(NSInteger)statusCode andDataSize:(long long)dataSize;
		[Export("finishWithStatusCode:andDataSize:")]
		void FinishWithStatusCode(nint statusCode, long dataSize);
	}

	// @interface Countly_OpenUDID : NSObject
	[BaseType(typeof(NSObject))]
	interface Countly_OpenUDID
	{
		// +(NSString *)value;
		[Static]
		[Export("value")]
		//[Verify(MethodToProperty)]
		string Value { get; }

		// +(NSString *)valueWithError:(NSError **)error;
		[Static]
		[Export("valueWithError:")]
		string ValueWithError(out NSError error);

		// +(void)setOptOut:(BOOL)optOutValue;
		[Static]
		[Export("setOptOut:")]
		void SetOptOut(bool optOutValue);
	}

	// @interface CountlyPersistency : NSObject
	[BaseType(typeof(NSObject))]
	interface CountlyPersistency
	{
		// +(instancetype)sharedInstance;
		[Static]
		[Export("sharedInstance")]
		CountlyPersistency SharedInstance();

		// -(void)addToQueue:(NSString *)queryString;
		[Export("addToQueue:")]
		void AddToQueue(string queryString);

		// -(void)removeFromQueue:(NSString *)queryString;
		[Export("removeFromQueue:")]
		void RemoveFromQueue(string queryString);

		// -(NSString *)firstItemInQueue;
		[Export("firstItemInQueue")]
		//[Verify(MethodToProperty)]
		string FirstItemInQueue { get; }

		// -(void)recordEvent:(CountlyEvent *)event;
		[Export("recordEvent:")]
		void RecordEvent(CountlyEvent @event);

		// -(NSString *)serializedRecordedEvents;
		[Export("serializedRecordedEvents")]
		//[Verify(MethodToProperty)]
		string SerializedRecordedEvents { get; }

		// -(void)recordTimedEvent:(CountlyEvent *)event;
		[Export("recordTimedEvent:")]
		void RecordTimedEvent(CountlyEvent @event);

		// -(CountlyEvent *)timedEventForKey:(NSString *)key;
		[Export("timedEventForKey:")]
		CountlyEvent TimedEventForKey(string key);

		// -(void)clearAllTimedEvents;
		[Export("clearAllTimedEvents")]
		void ClearAllTimedEvents();

		// -(void)saveToFile;
		[Export("saveToFile")]
		void SaveToFile();

		// -(void)saveToFileSync;
		[Export("saveToFileSync")]
		void SaveToFileSync();

		// -(NSString *)retrieveStoredDeviceID;
		[Export("retrieveStoredDeviceID")]
		//[Verify(MethodToProperty)]
		string RetrieveStoredDeviceID { get; }

		// -(void)storeDeviceID:(NSString *)deviceID;
		[Export("storeDeviceID:")]
		void StoreDeviceID(string deviceID);

		// -(NSString *)retrieveWatchParentDeviceID;
		[Export("retrieveWatchParentDeviceID")]
		//[Verify(MethodToProperty)]
		string RetrieveWatchParentDeviceID { get; }

		// -(void)storeWatchParentDeviceID:(NSString *)deviceID;
		[Export("storeWatchParentDeviceID:")]
		void StoreWatchParentDeviceID(string deviceID);

		// -(NSDictionary *)retrieveStarRatingStatus;
		[Export("retrieveStarRatingStatus")]
		//[Verify(MethodToProperty)]
		NSDictionary RetrieveStarRatingStatus { get; }

		// -(void)storeStarRatingStatus:(NSDictionary *)status;
		[Export("storeStarRatingStatus:")]
		void StoreStarRatingStatus(NSDictionary status);

		// -(BOOL)retrieveNotificationPermission;
		[Export("retrieveNotificationPermission")]
		//[Verify(MethodToProperty)]
		bool RetrieveNotificationPermission { get; }

		// -(void)storeNotificationPermission:(BOOL)allowed;
		[Export("storeNotificationPermission:")]
		void StoreNotificationPermission(bool allowed);

		// @property (nonatomic) NSUInteger eventSendThreshold;
		[Export("eventSendThreshold")]
		nuint EventSendThreshold { get; set; }

		// @property (nonatomic) NSUInteger storedRequestsLimit;
		[Export("storedRequestsLimit")]
		nuint StoredRequestsLimit { get; set; }
	}

	// @interface CountlyConnectionManager : NSObject <NSURLSessionDelegate>
	[BaseType(typeof(NSObject))]
	interface CountlyConnectionManager : INSUrlSessionDelegate
	{
		// @property (nonatomic, strong) NSString * appKey;
		[Export("appKey", ArgumentSemantic.Strong)]
		string AppKey { get; set; }

		// @property (nonatomic, strong) NSString * host;
		[Export("host", ArgumentSemantic.Strong)]
		string Host { get; set; }

		// @property (nonatomic, strong) NSURLSessionTask * connection;
		[Export("connection", ArgumentSemantic.Strong)]
		NSUrlSessionTask Connection { get; set; }

		// @property (nonatomic, strong) NSArray * pinnedCertificates;
		[Export("pinnedCertificates", ArgumentSemantic.Strong)]
		//[Verify(StronglyTypedNSArray)]
		NSObject[] PinnedCertificates { get; set; }

		// @property (nonatomic, strong) NSString * customHeaderFieldName;
		[Export("customHeaderFieldName", ArgumentSemantic.Strong)]
		string CustomHeaderFieldName { get; set; }

		// @property (nonatomic, strong) NSString * customHeaderFieldValue;
		[Export("customHeaderFieldValue", ArgumentSemantic.Strong)]
		string CustomHeaderFieldValue { get; set; }

		// @property (nonatomic, strong) NSString * secretSalt;
		[Export("secretSalt", ArgumentSemantic.Strong)]
		string SecretSalt { get; set; }

		// @property (nonatomic) BOOL alwaysUsePOST;
		[Export("alwaysUsePOST")]
		bool AlwaysUsePOST { get; set; }

		// +(instancetype)sharedInstance;
		[Static]
		[Export("sharedInstance")]
		CountlyConnectionManager SharedInstance();

		// -(void)beginSession;
		[Export("beginSession")]
		void BeginSession();

		// -(void)updateSession;
		[Export("updateSession")]
		void UpdateSession();

		// -(void)endSession;
		[Export("endSession")]
		void EndSession();

		// -(void)sendEvents;
		[Export("sendEvents")]
		void SendEvents();

		// -(void)sendUserDetails:(NSString *)userDetails;
		[Export("sendUserDetails:")]
		void SendUserDetails(string userDetails);

		// -(void)sendPushToken:(NSString *)token;
		[Export("sendPushToken:")]
		void SendPushToken(string token);

		// -(void)sendCrashReport:(NSString *)report immediately:(BOOL)immediately;
		[Export("sendCrashReport:immediately:")]
		void SendCrashReport(string report, bool immediately);

		// -(void)sendOldDeviceID:(NSString *)oldDeviceID;
		[Export("sendOldDeviceID:")]
		void SendOldDeviceID(string oldDeviceID);

		// -(void)sendParentDeviceID:(NSString *)parentDeviceID;
		[Export("sendParentDeviceID:")]
		void SendParentDeviceID(string parentDeviceID);

		// -(void)sendLocation:(CLLocationCoordinate2D)coordinate;
		[Export("sendLocation:")]
		void SendLocation(CLLocationCoordinate2D coordinate);

		// -(void)proceedOnQueue;
		[Export("proceedOnQueue")]
		void ProceedOnQueue();
	}

	// @interface CountlyEvent : NSObject <NSCoding>
	[BaseType(typeof(NSObject))]
	interface CountlyEvent : INSCoding
	{
		// @property (nonatomic, strong) NSString * key;
		[Export("key", ArgumentSemantic.Strong)]
		string Key { get; set; }

		// @property (nonatomic, strong) NSDictionary * segmentation;
		[Export("segmentation", ArgumentSemantic.Strong)]
		NSDictionary Segmentation { get; set; }

		// @property (nonatomic) NSUInteger count;
		[Export("count")]
		nuint Count { get; set; }

		// @property (nonatomic) double sum;
		[Export("sum")]
		double Sum { get; set; }

		// @property (nonatomic) NSTimeInterval timestamp;
		[Export("timestamp")]
		double Timestamp { get; set; }

		// @property (nonatomic) NSUInteger hourOfDay;
		[Export("hourOfDay")]
		nuint HourOfDay { get; set; }

		// @property (nonatomic) NSUInteger dayOfWeek;
		[Export("dayOfWeek")]
		nuint DayOfWeek { get; set; }

		// @property (nonatomic) NSTimeInterval duration;
		[Export("duration")]
		double Duration { get; set; }

		// -(NSDictionary *)dictionaryRepresentation;
		[Export("dictionaryRepresentation")]
		//[Verify(MethodToProperty)]
		NSDictionary DictionaryRepresentation { get; }
	}

	// @interface CountlyDeviceInfo : NSObject
	[BaseType(typeof(NSObject))]
	interface CountlyDeviceInfo
	{
		// @property (nonatomic, strong) NSString * deviceID;
		[Export("deviceID", ArgumentSemantic.Strong)]
		string DeviceID { get; set; }

		// +(instancetype)sharedInstance;
		[Static]
		[Export("sharedInstance")]
		CountlyDeviceInfo SharedInstance();

		// -(void)initializeDeviceID:(NSString *)deviceID;
		[Export("initializeDeviceID:")]
		void InitializeDeviceID(string deviceID);

		// -(NSString *)zeroSafeIDFA;
		[Export("zeroSafeIDFA")]
		//[Verify(MethodToProperty)]
		string ZeroSafeIDFA { get; }

		// +(NSString *)device;
		[Static]
		[Export("device")]
		//[Verify(MethodToProperty)]
		string Device { get; }

		// +(NSString *)architecture;
		[Static]
		[Export("architecture")]
		//[Verify(MethodToProperty)]
		string Architecture { get; }

		// +(NSString *)osName;
		[Static]
		[Export("osName")]
		//[Verify(MethodToProperty)]
		string OsName { get; }

		// +(NSString *)osVersion;
		[Static]
		[Export("osVersion")]
		//[Verify(MethodToProperty)]
		string OsVersion { get; }

		// +(NSString *)carrier;
		[Static]
		[Export("carrier")]
		//[Verify(MethodToProperty)]
		string Carrier { get; }

		// +(NSString *)resolution;
		[Static]
		[Export("resolution")]
	//	[Verify(MethodToProperty)]
		string Resolution { get; }

		// +(NSString *)density;
		[Static]
		[Export("density")]
	//	[Verify(MethodToProperty)]
		string Density { get; }

		// +(NSString *)locale;
		[Static]
		[Export("locale")]
	//	[Verify(MethodToProperty)]
		string Locale { get; }

		// +(NSString *)appVersion;
		[Static]
		[Export("appVersion")]
		//[Verify(MethodToProperty)]
		string AppVersion { get; }

		// +(NSString *)appBuild;
		[Static]
		[Export("appBuild")]
		//[Verify(MethodToProperty)]
		string AppBuild { get; }

		// +(NSString *)buildUUID;
		[Static]
		[Export("buildUUID")]
		//[Verify(MethodToProperty)]
		string BuildUUID { get; }

		// +(NSString *)bundleId;
		[Static]
		[Export("bundleId")]
	//	[Verify(MethodToProperty)]
		string BundleId { get; }

		// +(NSString *)executableName;
		[Static]
		[Export("executableName")]
		//[Verify(MethodToProperty)]
		string ExecutableName { get; }

		// +(NSInteger)hasWatch;
		//[Static]
		[Export("hasWatch")]
		//[Verify(MethodToProperty)]
		nint HasWatch { get; }

		// +(NSInteger)installedWatchApp;
		//[Static]
		[Export("installedWatchApp")]
	//	[Verify(MethodToProperty)]
		nint InstalledWatchApp { get; }

		// +(NSString *)metrics;
	//	[Static]
		[Export("metrics")]
	//	[Verify(MethodToProperty)]
		string Metrics { get; }

		// +(NSUInteger)connectionType;
	//	[Static]
		[Export("connectionType")]
		//[Verify(MethodToProperty)]
		nuint ConnectionType { get; }

		// +(unsigned long long)freeRAM;
	//	[Static]
		[Export("freeRAM")]
	//	[Verify(MethodToProperty)]
		ulong FreeRAM { get; }

		// +(unsigned long long)totalRAM;
	//	[Static]
		[Export("totalRAM")]
	//	[Verify(MethodToProperty)]
		ulong TotalRAM { get; }

		// +(unsigned long long)freeDisk;
		//[Static]
		[Export("freeDisk")]
		//[Verify(MethodToProperty)]
		ulong FreeDisk { get; }

		// +(unsigned long long)totalDisk;
		//[Static]
		[Export("totalDisk")]
		//[Verify(MethodToProperty)]
		ulong TotalDisk { get; }

		// +(NSInteger)batteryLevel;
		//[Static]
		[Export("batteryLevel")]
	//	[Verify(MethodToProperty)]
		nint BatteryLevel { get; }

		// +(NSString *)orientation;
		//[Static]
		[Export("orientation")]
	//	[Verify(MethodToProperty)]
		string Orientation { get; }

		// +(float)OpenGLESversion;
	//	[Static]
		[Export("OpenGLESversion")]
	//	[Verify(MethodToProperty)]
		float OpenGLESversion { get; }

		// +(BOOL)isJailbroken;
	//	[Static]
		[Export("isJailbroken")]
	//	[Verify(MethodToProperty)]
		bool IsJailbroken { get; }

		// +(BOOL)isInBackground;
	//	[Static]
		[Export("isInBackground")]
	//	[Verify(MethodToProperty)]
		bool IsInBackground { get; }
	}

	// @interface CountlyCrashReporter : NSObject
	[BaseType(typeof(NSObject))]
	interface CountlyCrashReporter
	{
		// @property (nonatomic, strong) NSDictionary * crashSegmentation;
		[Export("crashSegmentation", ArgumentSemantic.Strong)]
		NSDictionary CrashSegmentation { get; set; }

		// +(instancetype)sharedInstance;
		//[Static]
		[Export("sharedInstance")]
		CountlyCrashReporter SharedInstance();

		// -(void)startCrashReporting;
		[Export("startCrashReporting")]
		void StartCrashReporting();

		// -(void)recordHandledException:(NSException *)exception;
		[Export("recordHandledException:")]
		void RecordHandledException(NSException exception);

		// -(void)logWithFormat:(NSString *)format andArguments:(va_list)args;
		[Export("logWithFormat:andArguments:")]
        unsafe void LogWithFormat(string format, sbyte args);
	}

	// @interface CountlyViewTracking : NSObject
	[BaseType(typeof(NSObject))]
	interface CountlyViewTracking
	{
		// +(instancetype)sharedInstance;
		[Static]
		[Export("sharedInstance")]
		CountlyViewTracking SharedInstance();

		// -(void)reportView:(NSString *)viewName;
		[Export("reportView:")]
		void ReportView(string viewName);

		// -(void)endView;
		[Export("endView")]
		void EndView();

		// -(void)pauseView;
		[Export("pauseView")]
		void PauseView();

		// -(void)resumeView;
		[Export("resumeView")]
		void ResumeView();

		// -(void)startAutoViewTracking;
		[Export("startAutoViewTracking")]
		void StartAutoViewTracking();

		// -(void)addExceptionForAutoViewTracking:(NSString *)exception;
		[Export("addExceptionForAutoViewTracking:")]
		void AddExceptionForAutoViewTracking(string exception);

		// -(void)removeExceptionForAutoViewTracking:(NSString *)exception;
		[Export("removeExceptionForAutoViewTracking:")]
		void RemoveExceptionForAutoViewTracking(string exception);

		// @property (nonatomic) BOOL isAutoViewTrackingEnabled;
		[Export("isAutoViewTrackingEnabled")]
		bool IsAutoViewTrackingEnabled { get; set; }

		// @property (nonatomic, strong) NSString * lastView;
		[Export("lastView", ArgumentSemantic.Strong)]
		string LastView { get; set; }
	}

	// @interface CountlyViewTracking (UIViewController)
	[Category]
	[BaseType(typeof(UIViewController))]
	interface UIViewController_CountlyViewTracking
	{
		// -(void)Countly_viewDidAppear:(BOOL)animated;
		[Export("Countly_viewDidAppear:")]
		void Countly_viewDidAppear(bool animated);
	}

	// @interface CountlyStarRating : NSObject
	[BaseType(typeof(NSObject))]
	interface CountlyStarRating
	{
		// +(instancetype)sharedInstance;
		[Static]
		[Export("sharedInstance")]
		CountlyStarRating SharedInstance();

		// -(void)showDialog:(void (^)(NSInteger))completion;
		[Export("showDialog:")]
		void ShowDialog(Action<nint> completion);

		// -(void)checkForAutoAsk;
		[Export("checkForAutoAsk")]
		void CheckForAutoAsk();

		// @property (nonatomic, strong) NSString * message;
		[Export("message", ArgumentSemantic.Strong)]
		string Message { get; set; }

		// @property (nonatomic, strong) NSString * dismissButtonTitle;
		[Export("dismissButtonTitle", ArgumentSemantic.Strong)]
		string DismissButtonTitle { get; set; }

		// @property (nonatomic) NSUInteger sessionCount;
		[Export("sessionCount")]
		nuint SessionCount { get; set; }

		// @property (nonatomic) BOOL disableAskingForEachAppVersion;
		[Export("disableAskingForEachAppVersion")]
		bool DisableAskingForEachAppVersion { get; set; }

		// @property (copy, nonatomic) void (^ratingCompletionForAutoAsk)(NSInteger);
		[Export("ratingCompletionForAutoAsk", ArgumentSemantic.Copy)]
		Action<nint> RatingCompletionForAutoAsk { get; set; }
	}

	// @interface CountlyPushNotifications : NSObject <UNUserNotificationCenterDelegate>
	[BaseType(typeof(NSObject))]
	interface CountlyPushNotifications : IUNUserNotificationCenterDelegate
	{
		// @property (nonatomic) BOOL isTestDevice;
		[Export("isTestDevice")]
		bool IsTestDevice { get; set; }

		// @property (nonatomic) BOOL sendPushTokenAlways;
		[Export("sendPushTokenAlways")]
		bool SendPushTokenAlways { get; set; }

		// @property (nonatomic) BOOL doNotShowAlertForNotifications;
		[Export("doNotShowAlertForNotifications")]
		bool DoNotShowAlertForNotifications { get; set; }

		// +(instancetype)sharedInstance;
		[Static]
		[Export("sharedInstance")]
		CountlyPushNotifications SharedInstance();

		// -(void)startPushNotifications;
		[Export("startPushNotifications")]
		void StartPushNotifications();


		// -(void)askForNotificationPermissionWithOptions:(UNAuthorizationOptions)options completionHandler:(void (^)(BOOL, NSError *))completionHandler;
		[Export("askForNotificationPermissionWithOptions:completionHandler:")]
		void AskForNotificationPermissionWithOptions(UNAuthorizationOptions options, Action<bool, NSError> completionHandler);

	}

	// @interface CountlyPushNotifications (UIResponder)
	[Category]
	[BaseType(typeof(UIResponder))]
	interface UIResponder_CountlyPushNotifications
	{
		// -(void)Countly_application:(UIApplication *)application didRegisterForRemoteNotificationsWithDeviceToken:(NSData *)deviceToken;
		[Export("Countly_application:didRegisterForRemoteNotificationsWithDeviceToken:")]
		void Countly_application(UIApplication application, NSData deviceToken);

		// -(void)Countly_application:(UIApplication *)application didFailToRegisterForRemoteNotificationsWithError:(NSError *)error;
		[Export("Countly_application:didFailToRegisterForRemoteNotificationsWithError:")]
		void Countly_application(UIApplication application, NSError error);

		// -(void)Countly_application:(UIApplication *)application didRegisterUserNotificationSettings:(UIUserNotificationSettings *)notificationSettings;
		[Export("Countly_application:didRegisterUserNotificationSettings:")]
		void Countly_application(UIApplication application, UIUserNotificationSettings notificationSettings);

		// -(void)Countly_application:(UIApplication *)application didReceiveRemoteNotification:(NSDictionary *)userInfo fetchCompletionHandler:(void (^)(UIBackgroundFetchResult))completionHandler;
		[Export("Countly_application:didReceiveRemoteNotification:fetchCompletionHandler:")]
		void Countly_application(UIApplication application, NSDictionary userInfo, Action<UIBackgroundFetchResult> completionHandler);
	}

	//[Static]
	//[Verify(ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const kCountlyActionIdentifier;
		[Field("kCountlyActionIdentifier", "__Internal")]
		NSString kCountlyActionIdentifier { get; }

		// extern NSString *const kCountlyPNKeyCountlyPayload;
		[Field("kCountlyPNKeyCountlyPayload", "__Internal")]
		NSString kCountlyPNKeyCountlyPayload { get; }

		// extern NSString *const kCountlyPNKeyNotificationID;
		[Field("kCountlyPNKeyNotificationID", "__Internal")]
		NSString kCountlyPNKeyNotificationID { get; }

		// extern NSString *const kCountlyPNKeyButtons;
		[Field("kCountlyPNKeyButtons", "__Internal")]
		NSString kCountlyPNKeyButtons { get; }

		// extern NSString *const kCountlyPNKeyDefaultURL;
		[Field("kCountlyPNKeyDefaultURL", "__Internal")]
		NSString kCountlyPNKeyDefaultURL { get; }

		// extern NSString *const kCountlyPNKeyAttachment;
		[Field("kCountlyPNKeyAttachment", "__Internal")]
		NSString kCountlyPNKeyAttachment { get; }

		// extern NSString *const kCountlyPNKeyActionButtonIndex;
		[Field("kCountlyPNKeyActionButtonIndex", "__Internal")]
		NSString kCountlyPNKeyActionButtonIndex { get; }

		// extern NSString *const kCountlyPNKeyActionButtonTitle;
		[Field("kCountlyPNKeyActionButtonTitle", "__Internal")]
		NSString kCountlyPNKeyActionButtonTitle { get; }

		// extern NSString *const kCountlyPNKeyActionButtonURL;
		[Field("kCountlyPNKeyActionButtonURL", "__Internal")]
		NSString kCountlyPNKeyActionButtonURL { get; }
	}

	// @interface CountlyNotificationService : NSObject
	[BaseType(typeof(NSObject))]
	interface CountlyNotificationService
	{
		// +(void)didReceiveNotificationRequest:(UNNotificationRequest *)request withContentHandler:(void (^)(UNNotificationContent *))contentHandler;
		[Static]
		[Export("didReceiveNotificationRequest:withContentHandler:")]
		void DidReceiveNotificationRequest(UNNotificationRequest request, Action<UNNotificationContent> contentHandler);
	}

	//[Static]
	//[Verify(ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const kCountlySDKVersion;
		[Field("kCountlySDKVersion", "__Internal")]
		NSString kCountlySDKVersion { get; }

		// extern NSString *const kCountlySDKName;
		[Field("kCountlySDKName", "__Internal")]
		NSString kCountlySDKName { get; }
	}

	// @interface CountlyCommon : NSObject
	[BaseType(typeof(NSObject))]
	interface CountlyCommon
	{
		// @property (nonatomic) BOOL enableDebug;
		[Export("enableDebug")]
		bool EnableDebug { get; set; }

		// @property (nonatomic) BOOL enableAppleWatch;
		[Export("enableAppleWatch")]
		bool EnableAppleWatch { get; set; }

		// @property (nonatomic) BOOL manualSessionHandling;
		[Export("manualSessionHandling")]
		bool ManualSessionHandling { get; set; }

		// @property (nonatomic, strong) NSString * ISOCountryCode;
		[Export("ISOCountryCode", ArgumentSemantic.Strong)]
		string ISOCountryCode { get; set; }

		// @property (nonatomic, strong) NSString * city;
		[Export("city", ArgumentSemantic.Strong)]
		string City { get; set; }

		// @property (nonatomic, strong) NSString * location;
		[Export("location", ArgumentSemantic.Strong)]
		string Location { get; set; }

		// @property (nonatomic, strong) NSString * IP;
		[Export("IP", ArgumentSemantic.Strong)]
		string IP { get; set; }

		// +(instancetype)sharedInstance;
		//[Static]
		[Export("sharedInstance")]
		CountlyCommon SharedInstance();

		// -(NSInteger)hourOfDay;
		[Export("hourOfDay")]
		//[Verify(MethodToProperty)]
		nint HourOfDay { get; }

		// -(NSInteger)dayOfWeek;
		[Export("dayOfWeek")]
		//[Verify(MethodToProperty)]
		nint DayOfWeek { get; }

		// -(NSInteger)timeZone;
		[Export("timeZone")]
	//	[Verify(MethodToProperty)]
		nint TimeZone { get; }

		// -(NSInteger)timeSinceLaunch;
		[Export("timeSinceLaunch")]
		//[Verify(MethodToProperty)]
		nint TimeSinceLaunch { get; }

		// -(NSTimeInterval)uniqueTimestamp;
		[Export("uniqueTimestamp")]
	//	[Verify(MethodToProperty)]
		double UniqueTimestamp { get; }

		// -(void)activateWatchConnectivity;
		[Export("activateWatchConnectivity")]
		void ActivateWatchConnectivity();

		// -(void)transferParentDeviceID;
		[Export("transferParentDeviceID")]
		void TransferParentDeviceID();
	}

	// @interface CLYInternalViewController : UIViewController
	[BaseType(typeof(UIViewController))]
	interface CLYInternalViewController
	{
	}

	// @interface CLYButton : UIButton
	[BaseType(typeof(UIButton))]
	interface CLYButton
	{
		// @property (copy, nonatomic) void (^onClick)(id);
		[Export("onClick", ArgumentSemantic.Copy)]
		Action<NSObject> OnClick { get; set; }

		// +(CLYButton *)dismissAlertButton;
		//[Static]
		[Export("dismissAlertButton")]
		//[Verify(MethodToProperty)]
		CLYButton DismissAlertButton { get; }
	}

	// @interface Countly (NSString)
	[Category]
	[BaseType(typeof(NSString))]
	interface NSString_Countly
	{
		// -(NSString *)cly_URLEscaped;
		[Static,Export("cly_URLEscaped")]
		//[Verify(MethodToProperty)]
		string Cly_URLEscaped { get; }

		// -(NSString *)cly_SHA256;
		[Static,Export("cly_SHA256")]
		//[Verify(MethodToProperty)]
		string Cly_SHA256 { get; }

		// -(NSData *)cly_dataUTF8;
		[Static,Export("cly_dataUTF8")]
		//[Verify(MethodToProperty)]
		NSData Cly_dataUTF8 { get; }
	}

	// @interface Countly (NSArray)
	[Category]
	[BaseType(typeof(NSArray))]
	interface NSArray_Countly
	{
		// -(NSString *)cly_JSONify;
		[Static,Export("cly_JSONify")]
	//	[Verify(MethodToProperty)]
		string Cly_JSONify { get; }
	}

	// @interface Countly (NSDictionary)
	[Category]
	[BaseType(typeof(NSDictionary))]
	interface NSDictionary_Countly
	{
		// -(NSString *)cly_JSONify;
		[Static,Export("cly_JSONify")]
	//	[Verify(MethodToProperty)]
		string Cly_JSONify { get; }
	}

	// @interface Countly (NSData)
	[Category]
	[BaseType(typeof(NSData))]
	interface NSData_Countly
	{
		// -(NSString *)cly_stringUTF8;
		[Static,Export("cly_stringUTF8")]
		//[Verify(MethodToProperty)]
		string Cly_stringUTF8 { get; }
	}

	// @interface RecordEventWithTimeStamp (Countly)
	[Category]
	[BaseType(typeof(Countly))]
	interface Countly_RecordEventWithTimeStamp
	{
		// -(void)recordEvent:(NSString *)key segmentation:(NSDictionary *)segmentation count:(NSUInteger)count sum:(double)sum duration:(NSTimeInterval)duration timestamp:(NSTimeInterval)timestamp;
		[Static, Export("recordEvent:segmentation:count:sum:duration:timestamp:")]
		void RecordEvent(string key, NSDictionary segmentation, nuint count, double sum, double duration, double timestamp);
	}
   	
	
}
