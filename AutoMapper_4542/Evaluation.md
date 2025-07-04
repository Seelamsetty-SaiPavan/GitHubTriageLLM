\# 🧪 LLM Evaluation – AutoMapper Issue #4542



🔗 \[GitHub Issue](https://github.com/LuckyPennySoftware/AutoMapper/issues/4542)



\## 🐛 Problem



AutoMapper v15 removed the `MapperConfiguration(cfg => { ... })` constructor, causing compile-time errors for many existing codebases.  

The LLM suggested using `MapperConfigurationExpression`, which was \*\*partially correct\*\*, but failed to compile under v15.



\## 🧠 LLM Prompt



> In AutoMapper v15, this constructor is removed:  

> `var config = new MapperConfiguration(cfg => { ... });`  

> How do I define mappings now?



\## 🤖 LLM Response



ChatGPT suggested replacing with `MapperConfigurationExpression` and a bridging profile, but this didn’t compile directly.



\## 🧪 Human Validation



To properly validate the LLM's suggestion, I downgraded to \*\*AutoMapper v13.0.1\*\*, where the original constructor is supported and LLM suggestion can be verified.



```csharp

var config = new MapperConfiguration(cfg =>

{

&nbsp;   cfg.CreateMap<Source, Destination>();

});

