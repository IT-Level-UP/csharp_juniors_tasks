using LevelUp.CsharpJuniors.Tasks.Lesson4.Attributes;
using LevelUp.CsharpJuniors.Tasks.Lesson4.Caching;
using LevelUp.CsharpJuniors.Tasks.Lesson4.Generics;
using LevelUp.CsharpJuniors.Tasks.Lesson4.Reflection;
using LevelUp.CsharpJuniors.Tasks.Lesson4.Statics;

new GenericsExamples().DealWithGenerics();
new StaticsExamples().DealWithStatics();
new CachingExamples().DealWithCaches();
new ReflectionExamples().DealWithInstance();
new ReflectionExamples().DealWithTypeInfo(typeof(string));
new AttributesExamples().DealWithAttributesInfo();