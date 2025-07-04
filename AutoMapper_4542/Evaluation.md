# 🧪 LLM Evaluation – AutoMapper Issue #4542

🔗 [GitHub Issue](https://github.com/LuckyPennySoftware/AutoMapper/issues/4542)

---

## 🐛 Problem

AutoMapper v15 removed the `MapperConfiguration(cfg => { ... })` constructor, causing compile-time errors for many existing codebases.  

The LLM suggested using `MapperConfigurationExpression`, which was **partially correct**, but failed to compile under v15 due to breaking changes.

---

## 🧠 LLM Prompt

> In AutoMapper v15, this constructor is removed:  
> `var config = new MapperConfiguration(cfg => { ... });`  
> How do I define mappings now?

---

## 🤖 LLM Response

ChatGPT suggested replacing the constructor with a more manual setup using `MapperConfigurationExpression` and a dynamic `Profile`, but this did not compile directly under v15 without internal workarounds.

---

## 🧪 Human Validation

To properly validate the LLM's suggestion, I downgraded to **AutoMapper v13.0.1**, where the original constructor is still supported and the LLM suggestion could be verified in a real project.

### ✅ Working Code

```csharp
var config = new MapperConfiguration(cfg =>
{
    cfg.CreateMap<Source, Destination>();
});
