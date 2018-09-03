require('jquery')

export default function prettyDate(birthday) {
    if (!birthday) return "";

    var date = new Date(birthday),
        diff = (((new Date()).getTime() - date.getTime()) / 1000),
        day_diff = Math.floor(diff / 86400);

    var months = ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Oct", "Nov", "Dec"];

    if (isNaN(day_diff) || day_diff < 0 || (day_diff >= 31 && day_diff <= 365)) {
        return months[date.getMonth()] + " " + date.getDate();
    }

    if (day_diff > 365) {
        return date.getDate().toString() + "/" + (date.getMonth() + 1) + "/" + date.getFullYear();
    }

    if (day_diff === 0)
        return diff < 60 && "just now" ||
            diff < 120 && "1 minute ago" ||
            diff < 3600 && Math.floor(diff / 60) + " minutes ago" ||
            diff < 7200 && "1 hour ago" ||
            diff < 86400 && Math.floor(diff / 3600) + " hours ago";

    if (day_diff === 1) return "Yesterday";

    if (day_diff < 7)
        return day_diff + " days ago";

    if (day_diff < 31)
        return Math.ceil(day_diff / 7) + " weeks ago";

}