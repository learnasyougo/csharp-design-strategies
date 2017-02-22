using System;
using System.Collections.Generic;
using System.Reflection;
using Xunit;

namespace Singleton
{
    public class SingletonClient
    {
        public void UseSingleton() {
            SingletonWithoutState.TheReasonIExist();
            SingletonWithState.Instance.TheReasonIExist();
            LazySingletonWithState.Instance.TheReasonIExist();
            EasyLazySingletonWithState.Instance.TheReasonIExist();
        }

        [Theory]
        [MemberData(nameof(SingletonTestData))]
        public void Instances_Points_To_Same_Reference(object a, object b, bool expected) {
            Assert.Equal(expected, ReferenceEquals(a, b));
            Assert.Equal(expected, a == b);
        }

        public static IEnumerable<object[]> SingletonTestData
        {
            get
            {
                // To be sure, check the values and see if they're the same
                yield return new object[] {
                    SingletonWithState.Instance,
                    SingletonWithState.Instance,
                    true
                };
                yield return new object[] {
                    LazySingletonWithState.Instance,
                    LazySingletonWithState.Instance,
                    true
                };
                yield return new object[] {
                    EasyLazySingletonWithState.Instance,
                    EasyLazySingletonWithState.Instance,
                    true
                };

                // Though, be aware
                // we can be evil with reflection!                
                yield return new object[] {
                    Construct<SingletonWithState>(),
                    Construct<SingletonWithState>(),
                    false
                };
                yield return new object[] {
                    Construct<LazySingletonWithState>(),
                    Construct<LazySingletonWithState>(),
                    false
                };
                yield return new object[] {
                    Construct<EasyLazySingletonWithState>(),
                    Construct<EasyLazySingletonWithState>(),
                    false
                };

                // Also be aware of thread-safety..
                // No example given here to create
                // - Although SingletonWithState, LazySingletonWithState 
                //   and EasyLazySingletonWithState are thread safe 
                //   but only IF their method implementation
                //   takes that into account ;-).
            }
        }

        public static T Construct<T>() {
            var t = typeof(T);

            var constructorInfo = t.GetConstructor(
                BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { }, null);
            return (T)constructorInfo.Invoke(new object[] { });
        }
    }
}
