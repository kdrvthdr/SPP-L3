using NUnit.Framework;
using AssemblyBrowserLibrary;
using AssemblyBrowserLibrary.AssemblyComposition;

namespace Tests
{
    [TestFixture]
    public class TestAssemblyBrowser
    {
        private AssemblyBrowser _assemblyBrowser;

        [SetUp]
        public void Setup()
        {
            // Укажите путь к тестовой сборке
            string assemblyPath = "D:\\FY\\SPP-L3\\AssemblyBrowserLibrary\\bin\\Debug\\net6.0\\AssemblyBrowserLibrary.dll";
            _assemblyBrowser = new AssemblyBrowser(assemblyPath);
        }

        [Test]
        public void LoadAssemblyFromFile_Success()
        {
            // Получаем информацию о сборке
            AssemblyInfo assemblyInfo = _assemblyBrowser.GetAssemblyInfo();

            // Проверяем, что объект assemblyInfo не равен null, что указывает на успешную загрузку сборки
            Assert.IsNotNull(assemblyInfo.Namespaces);
        }
        [Test]
        public void AssemblyInfoContainsTypes()
        {
            // Получаем информацию о сборке
            AssemblyInfo assemblyInfo = _assemblyBrowser.GetAssemblyInfo();

            // Проверяем, что объект assemblyInfo содержит информацию о типах
            foreach (var namespaceInfo in assemblyInfo.Namespaces)
            {
                foreach (var typeInfo in namespaceInfo.Types)
                {
                    Assert.IsNotNull(typeInfo.TypeName);
                }
            }
        }
        [Test]
        public void AssemblyInfoContainsNamespaces()
        {
            // Получаем информацию о сборке
            AssemblyInfo assemblyInfo = _assemblyBrowser.GetAssemblyInfo();

            // Проверяем, что объект assemblyInfo содержит информацию о пространствах имен
            Assert.IsNotNull(assemblyInfo.Namespaces);
            Assert.IsNotEmpty(assemblyInfo.Namespaces);
        }
        [Test]
        public void AssemblyInfoContainsFields()
        {
            // Получаем информацию о сборке
            AssemblyInfo assemblyInfo = _assemblyBrowser.GetAssemblyInfo();

            // Проверяем, что объект assemblyInfo содержит информацию о полях
            foreach (var namespaceInfo in assemblyInfo.Namespaces)
            {
                foreach (var typeInfo in namespaceInfo.Types)
                {
                    foreach (var fieldInfo in typeInfo.Fields)
                    {
                        Assert.IsNotNull(fieldInfo.FieldName);
                    }
                }
            }
        }

        [Test]
        public void AssemblyInfoContainsMethods()
        {
            // Получаем информацию о сборке
            AssemblyInfo assemblyInfo = _assemblyBrowser.GetAssemblyInfo();

            // Проверяем, что объект assemblyInfo содержит информацию о методах
            foreach (var namespaceInfo in assemblyInfo.Namespaces)
            {
                foreach (var typeInfo in namespaceInfo.Types)
                {
                    foreach (var methodInfo in typeInfo.Methods)
                    {
                        Assert.IsNotNull(methodInfo.MethodName);
                    }
                }
            }
        }
        [Test]
        public void AssemblyInfoContainsProperties()
        {
            // Получаем информацию о сборке
            AssemblyInfo assemblyInfo = _assemblyBrowser.GetAssemblyInfo();

            // Проверяем, что объект assemblyInfo содержит информацию о свойствах
            foreach (var namespaceInfo in assemblyInfo.Namespaces)
            {
                foreach (var typeInfo in namespaceInfo.Types)
                {
                    foreach (var propertyInfo in typeInfo.Properties)
                    {
                        Assert.IsNotNull(propertyInfo.PropertyName);
                    }
                }
            }
        }

        [Test]
        public void AssemblyMethodInfoContainsParameters()
        {
            // Получаем информацию о сборке
            AssemblyInfo assemblyInfo = _assemblyBrowser.GetAssemblyInfo();

            // Проверяем, что объект assemblyInfo содержит информацию о параметрах методов
            foreach (var namespaceInfo in assemblyInfo.Namespaces)
            {
                foreach (var typeInfo in namespaceInfo.Types)
                {
                    foreach (var methodInfo in typeInfo.Methods)
                    {
                        foreach (var parameterInfo in methodInfo.Parameters)
                        {
                            Assert.IsNotNull(parameterInfo.FieldName);
                        }
                    }
                }
            }
        }
        // Дополнительные тесты могут включать проверку наличия информации о типах, полях, свойствах и методах
        // Для этого можно создать дополнительные методы проверки в классе TestAssemblyBrowser
    }
}
