/* Modern & Clean Design with your preferred color */
        :root {
            --primary-color: #55c57a; /* A vibrant green */
            --primary-light: #dcffdb;
            --secondary-color: #2c3e50; /* Dark blue for deeper contrast */
            --text-color: #333;
            --bg-color: #f8f9fa;
            --container-bg: #ffffff;
            --shadow-color: rgba(0,0,0,0.08);
            --header-color: var(--secondary-color);
            --border-color: #e0e0e0;
            --link-color: var(--primary-color);
            --link-bg: var(--primary-light);
            --link-hover-bg: var(--primary-color);
            --link-hover-color: #fff;
            --project-card-bg: #ffffff;
            --project-card-border: #f0f0f0;
            --project-title-color: var(--secondary-color);
            --footer-color: #777;
            --toggle-bg: #ccc;
            --toggle-circle: #fff;
            --highlight-color: var(--primary-color);
            --code-bg: #2d2d2d;
            --code-text: #f8f8f2;
            --news-bg: #f1f5f9;
            --news-border: #e2e8f0;
        }

        body.dark-mode {
            --primary-color: #8be9fd; /* Lighter blue for dark mode accents */
            --primary-light: #283a4d;
            --secondary-color: #f8f8f2; /* Light text for dark mode */
            --text-color: #f8f8f2;
            --bg-color: #282a36; /* Dracula Theme background */
            --container-bg: #21222c;
            --shadow-color: rgba(0,0,0,0.4);
            --header-color: var(--primary-color);
            --border-color: #44475a;
            --link-color: var(--primary-color);
            --link-bg: #44475a;
            --link-hover-bg: var(--primary-color);
            --link-hover-color: #282a36;
            --project-card-bg: #21222c;
            --project-card-border: #44475a;
            --project-title-color: var(--primary-color);
            --footer-color: #aaa;
            --toggle-bg: #6272a4;
            --toggle-circle: #f8f8f2;
            --highlight-color: #bd93f9; /* Purple for highlights */
            --code-bg: #1e1e1e;
            --code-text: #d4d4d4;
            --news-bg: #2d3748;
            --news-border: #4a5568;
        }

        body {
            font-family: "Kanit", sans-serif;
            font-weight: 400;
            line-height: 1.7;
            background-color: var(--bg-color);
            color: var(--text-color);
            margin: 0;
            padding: 30px;
            transition: background-color 0.4s ease, color 0.4s ease;
        }
        .container {
            max-width: 1200px;
            margin: auto;
        }
        
        .top-bar {
            display: flex;
            justify-content: space-between;
            align-items: center;
            margin-bottom: 20px;
        }

        .theme-switch-wrapper {
            display: flex;
            align-items: center;
            gap: 10px;
        }
        .theme-switch {
            display: inline-block;
            height: 34px;
            position: relative;
            width: 60px;
        }
        .theme-switch input { display: none; }
        .slider {
            background-color: var(--toggle-bg);
            bottom: 0;
            cursor: pointer;
            left: 0;
            position: absolute;
            right: 0;
            top: 0;
            transition: .4s;
            border-radius: 34px;
        }
        .slider:before {
            background-color: var(--toggle-circle);
            bottom: 4px;
            content: "";
            height: 26px;
            left: 4px;
            position: absolute;
            transition: .4s;
            width: 26px;
            border-radius: 50%;
        }
        input:checked + .slider { background-color: var(--primary-color); }
        input:checked + .slider:before { transform: translateX(26px); }

        .main-layout {
            display: grid;
            grid-template-columns: 1fr;
            gap: 40px;
        }

        @media (min-width: 1024px) {
            .main-layout {
                grid-template-columns: 2fr 1fr;
            }
        }

        .main-content, .sidebar {
            background: var(--container-bg);
            padding: 30px;
            border-radius: 15px;
            box-shadow: 0 8px 30px var(--shadow-color);
            transition: background 0.4s ease, box-shadow 0.4s ease;
        }

        .header {
            display: flex;
            align-items: center;
            gap: 20px;
            margin-bottom: 40px;
        }
        .profile-img {
            width: 100px;
            height: 100px;
            border-radius: 50%;
            object-fit: cover;
            border: 4px solid var(--primary-color);
        }
        .header-text h1 {
            margin: 0;
            font-size: 2.5em;
            font-weight: 700;
            color: var(--secondary-color);
        }
        .header-text h2 {
            margin: 0;
            font-size: 1.2em;
            color: var(--header-color);
            font-weight: 400;
        }

        h3 {
            border-bottom: 2px solid var(--border-color);
            padding-bottom: 12px;
            margin-top: 40px;
            margin-bottom: 25px;
            font-size: 1.8em;
            font-weight: 600;
            display: flex;
            align-items: center;
            color: var(--secondary-color);
        }
        h3:first-child {
            margin-top: 0;
        }
        h3 i {
            margin-right: 12px;
            color: var(--primary-color);
            font-size: 1.2em;
        }

        .highlight {
            color: var(--highlight-color);
            font-weight: 600;
        }

        /* News Section */
        .news-section h3 {
            margin-top: 0;
        }
        .news-list {
            list-style: none;
            padding: 0;
            margin: 0;
        }
        .news-item {
            margin-bottom: 15px;
            padding-bottom: 15px;
            border-bottom: 1px solid var(--border-color);
        }
        .news-item:last-child {
            border-bottom: none;
            margin-bottom: 0;
            padding-bottom: 0;
        }
        .news-item .news-category {
            display: inline-block;
            padding: 3px 10px;
            border-radius: 20px;
            font-size: 0.8em;
            font-weight: 600;
            margin-right: 8px;
            color: #fff;
        }
        .news-category.update { background-color: #3498db; }
        .news-category.release { background-color: #2ecc71; }
        .news-category.announcement { background-color: #f39c12; }
        .news-item p {
            margin: 5px 0 0;
            font-size: 0.95em;
        }
        .news-item time {
            font-size: 0.8em;
            color: var(--footer-color);
            display: block;
            margin-top: 5px;
        }

        /* Maven/Code Section */
        .code-block {
            background-color: var(--code-bg);
            border-radius: 8px;
            padding: 15px;
            margin-bottom: 15px;
            position: relative;
            overflow-x: auto;
        }
        .code-block h4 {
            margin: 0 0 10px;
            font-weight: 500;
            color: #9cdcfe;
        }
        pre {
            margin: 0;
            font-family: 'Fira Code', monospace;
            font-size: 0.9em;
            color: var(--code-text);
        }
        .copy-btn {
            position: absolute;
            top: 10px;
            right: 10px;
            background: #4a4a4a;
            border: none;
            color: #fff;
            padding: 5px 10px;
            border-radius: 5px;
            cursor: pointer;
            font-size: 0.8em;
            opacity: 0.7;
            transition: opacity 0.2s;
        }
        .copy-btn:hover {
            opacity: 1;
        }
        .copy-btn.copied {
            background-color: var(--primary-color);
        }

        /* Projects Section */
        .project-grid {
            display: grid;
            grid-template-columns: repeat(auto-fill, minmax(300px, 1fr));
            gap: 25px;
        }
        .project-card {
            background: var(--project-card-bg);
            border: 1px solid var(--project-card-border);
            border-radius: 10px;
            padding: 20px;
            transition: transform 0.3s ease, box-shadow 0.3s ease;
            display: flex;
            flex-direction: column;
        }
        .project-card:hover {
            transform: translateY(-5px);
            box-shadow: 0 10px 20px rgba(0,0,0,0.1);
        }
        body.dark-mode .project-card:hover {
            box-shadow: 0 10px 20px rgba(0,0,0,0.3);
        }
        .project-card h4 {
            margin-top: 0;
            margin-bottom: 10px;
            font-size: 1.3em;
            color: var(--project-title-color);
        }
        .project-card p {
            margin-bottom: 15px;
            flex-grow: 1;
            font-size: 0.95em;
        }
        .project-links {
            margin-top: auto;
            display: flex;
            flex-wrap: wrap;
            gap: 8px;
        }
        .project-links a {
            text-decoration: none;
            padding: 6px 12px;
            font-size: 0.9em;
            background-color: var(--link-bg);
            color: var(--link-color);
            border: 1px solid var(--link-color);
            border-radius: 5px;
            transition: all 0.2s ease;
            display: inline-flex;
            align-items: center;
        }
        .project-links a:hover {
            background-color: var(--link-hover-bg);
            color: var(--link-hover-color);
        }
        .project-links a i {
            margin-right: 5px;
        }

        /* Links Section */
        .links ul {
            list-style: none;
            padding: 0;
            display: flex;
            flex-wrap: wrap;
            gap: 12px;
        }
        .links a {
            text-decoration: none;
            color: var(--link-color);
            background-color: var(--link-bg);
            padding: 8px 15px;
            border-radius: 8px;
            transition: background-color 0.3s, color 0.3s;
            display: inline-flex;
            align-items: center;
            font-weight: 500;
        }
        .links a:hover {
            background-color: var(--link-hover-bg);
            color: var(--link-hover-color);
        }
        .links a i {
            margin-right: 8px;
        }

        footer {
            text-align: center;
            margin-top: 40px;
            padding-top: 20px;
            border-top: 1px solid var(--border-color);
            color: var(--footer-color);
            font-size: 0.9em;
        }

        /* Responsive */
        @media (max-width: 768px) {
            body { padding: 15px; }
            .header { flex-direction: column; text-align: center; }
            .main-content, .sidebar { padding: 20px; }
            h1 { font-size: 2em; }
            h2 { font-size: 1.1em; }
            h3 { font-size: 1.5em; }
        }
