document.addEventListener('DOMContentLoaded', function () {
    const input = document.querySelector('input[name="Busqueda"]');
    const filas = document.querySelectorAll('tbody tr');

    if (input) {
        input.addEventListener('input', function () {
            const termino = this.value.toLowerCase();

            filas.forEach(fila => {
                const nombre = fila.cells[1].textContent.toLowerCase();
                fila.style.display = nombre.includes(termino) ? '' : 'none';
            });
        });
    }
});

