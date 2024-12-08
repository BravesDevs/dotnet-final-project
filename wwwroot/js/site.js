
function toggleFavorite() {
    const button = document.getElementById('favoriteButton');
    const icon = button.querySelector('i');

    if (icon.classList.contains('bi-heart')) {
    icon.classList.remove('bi-heart');
    icon.classList.add('bi-heart-fill');
    button.classList.remove('btn-outline-secondary');
    button.classList.add('btn-danger');
    }
    else {
    icon.classList.remove('bi-heart-fill');
    icon.classList.add('bi-heart');
    button.classList.remove('btn-danger');
    button.classList.add('btn-outline-secondary');
    }
}