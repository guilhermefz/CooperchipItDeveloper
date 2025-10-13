(function () {
    const input = document.getElementById('searchBox');
    const tbody = document.querySelector('#mainTable tbody');
    if (!input || !tbody) return;

    const normalize = s => (s || '').toLowerCase().normalize('NFD').replace(/[\u0300-\u036f]/g, '').trim();

    const cache = Array.from(tbody.querySelectorAll('tr')).map(row => {
        const codigo = normalize(row.querySelector('td:nth-child(1)')?.textContent);
        const nome = normalize(row.querySelector('td:nth-child(2)')?.textContent);
        const words = nome.split(/\s+/).filter(Boolean);
        return { row, codigo, nome, words };
    });

    let timer;
    input.addEventListener('input', () => {
        clearTimeout(timer);
        timer = setTimeout(() => {
            const q = normalize(input.value);
            if (!q) {
                cache.forEach(c => c.row.style.display = '');
                return;
            }
            cache.forEach(c => {
                const ok = c.codigo.startsWith(q) || c.nome.startsWith(q) || c.words.some(w => w.startsWith(q));
                c.row.style.display = ok ? '' : 'none';
            });
        }, 150);
    });

    if (input.value) input.dispatchEvent(new Event('input'));
})();