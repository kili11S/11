document.addEventListener('DOMContentLoaded', function () {
    // Функция для выполнения асинхронного GET-запроса
    async function fetchData(url) {
        try {
            const response = await fetch(url);
            const data = await response.json();
            return data;
        } catch (error) {
            console.error('Error fetching data:', error);
        }
    }

    // Функция для отображения материалов на веб-странице
    function displayMaterial(material) {
        const materialList = document.getElementById('material-list');
        materialList.innerHTML = '';

        material.forEach(item => {
            const li = document.createElement('li');
            li.textContent = Material ID: ${item.id}, Name: ${item.name}, Mass: ${item.mass}, Cubic Metres: ${item.cubicmetres};
            materialList.appendChild(li);
        });
    }

    // Функция для отображения складов на веб-странице
    function displayStorages(storages) {
        const storageList = document.getElementById('storage-list');
        storageList.innerHTML = '';

        storages.forEach(item => {
            const li = document.createElement('li');
            li.textContent = Storage ID: ${item.id}, Address: ${item.address}, Size in Metres: ${item.sizemetres};
            storageList.appendChild(li);
        });
    }

    // Функция для отображения поставщиков на веб-странице
    function displaySuppliers(suppliers) {
        const supplierList = document.getElementById('supplier-list');
        supplierList.innerHTML = '';

        suppliers.forEach(item => {
            const li = document.createElement('li');
            li.textContent = Supplier ID: ${item.id}, Name: ${item.name}, Contacts: ${item.contacts}, Supplied Material ID: ${item.supplied_mat};
            supplierList.appendChild(li);
        });
    }

    // Загрузка данных при загрузке страницы
    fetchData('/api/material')
        .then(data => displayMaterial(data));

    fetchData('/api/storages')
        .then(data => displayStorages(data));

    fetchData('/api/suppliers')
        .then(data => displaySuppliers(data));
});